<?php

namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use App\Models\Pedido;
use Illuminate\Http\JsonResponse;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Exception;

class PedidoController extends Controller
{
    public function index(): JsonResponse
    {
        $pedidos = Pedido::orderBy('id', 'DESC')->get();

        return response()->json([
            'status' => true,
            'pedidos' => $pedidos,
        ], 200);
    }

    public function show(Pedido $pedido): JsonResponse
    {
        return response()->json([
            'status' => true,
            'pedidos' => $pedido,
        ], 200);
    }

    public function store(Request $request)
    {
        DB::beginTransaction();

        try {

           $pedido = Pedido::create([
                "codpedido" => $request->codpedido,
                "telefone" => $request->telefone,
                "nome" => $request->nome,
                "descricao" => $request->descricao,
                "vlunit" => $request->vlunit,
                "status" => $request->status,
                "fpage" => $request->fpage,
                "vltotal" => $request->vltotal,
                "endereco" => $request->endereco,
                "complemento" => $request->complemento,
                "cdcard" => $request->cdcard,
            ]);

            DB::commit();

            return response()->json([
                'status' => true,
                'pedido' => $pedido,
                'message' => "Pedido Cadastrado com sucesso!",
            ], 201);

        } catch (Exception $e) {

            DB::rollBack();

            return response()->json([
                'status' => false,
                'message' => "Pedido nao cadastrado!",
            ], 400);
        }
    }

    public function update(Request $request, Pedido $pedido) : JsonResponse
    {
        DB::beginTransaction();

        try{

            $pedido->update([
                "codpedido" => $request->codpedido,
                "telefone" => $request->telefone,
                "nome" => $request->nome,
                "descricao" => $request->descricao,
                "vlunit" => $request->vlunit,
                "status" => $request->status,
                "fpage" => $request->fpage,
                "vltotal" => $request->vltotal,
                "endereco" => $request->endereco,
                "complemento" => $request->complemento,
                "cdcard" => $request->cdcard,
            ]);

        DB::commit();

            return response()->json([
                'status' => true,
                'pedido' => $pedido,
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

    public function destroy(Pedido $pedido) : JsonResponse
    {
        try {

            $pedido->delete();

            return response()->json([
                'status' => true,
                'pedido' => $pedido,
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
