<?php

namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use App\Models\Cliente;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Http\JsonResponse;
use Illuminate\Support\Facades\DB;


//    return ClienteResource::collection(Cliente::all());

class ClienteController extends Controller
{
    public function index(): JsonResponse
    {
        $clientes = Cliente::orderBy('id', 'DESC')->paginate(15);

        return response()->json([
            'status' => true,
            'clientes' => $clientes,
        ], 200);
    }

    public function show(cliente $cliente): JsonResponse
    {
        return response()->json([
            'status' => true,
            'cliente' => $cliente,
        ], 200);
    }

    public function store(Request $request)
    {
        DB::beginTransaction();

        try {

           $cliente = Cliente::create([
                'nome' => $request->nome,
                'endereco' => $request->endereco,
                'telefone' => $request->telefone,
                'complemento' => $request->complemento,
                'email' => $request->email,
                'cep' => $request->cep,
            ]);

            DB::commit();

            return response()->json([
                'status' => true,
                'cliente' => $cliente,
                'message' => "Cliente Cadastrado com sucesso!",
            ], 201);

        } catch (Exception $e) {

            DB::rollBack();

            return response()->json([
                'status' => false,
                'message' => "Cliente nao cadastrado!",
            ], 400);
        }
    }

    public function update(Request $request, Cliente $cliente) : JsonResponse
    {
        DB::beginTransaction();

        try{

            $cliente->update([
            'nome' => $request->nome,
            'endereco' => $request->endereco,
            'telefone' => $request->telefone,
            'complemento' => $request->complemento,
            'email' => $request->email,
            'cep' => $request->cep,
        
        ]);

        DB::commit();

            return response()->json([
                'status' => true,
                'cliente' => $cliente,
                'message' => "Cliente Cadastrado com sucesso!",
            ], 200);

        }catch (Exception $e){

            DB::rollBack();

            return response()->json([
                'status' => false,
                'message' => "Cliente nao cadastrado!",
            ], 400);
        }
    }

    public function destroy(Cliente $cliente) : JsonResponse
    {
        try {

            $cliente->delete();

            return response()->json([
                'status' => true,
                'cliente' => $cliente,
                'message' => "Cliente Deletado com sucesso!",
            ], 200);


        }catch (Exception $e){
          
            return response()->json([
                'status' => false,
                'message' => "Cliente não Deletado!"
            ], 400);
        }
    }

}
