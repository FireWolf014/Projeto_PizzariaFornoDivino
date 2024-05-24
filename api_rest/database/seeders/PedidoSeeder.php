<?php

namespace Database\Seeders;

use App\Models\Pedido;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\Hash;

class PedidoSeeder extends Seeder
{
    
    public function run(): void
    {

        if(!Pedido::where('codpedido', '0001')->first()){
            Pedido::create([
                'codpedido' => '0001',
                'telefone' => '11979698090',
                'nome' => 'Joao Silva',
                'descricao' => 'Pizza de Calabresa',
                'vlunit' => 45.99,
                'status' => 'Sendo Preparado',
                'fpage' => 'Cartao Credito',
                'vltotal' => 45.99,
                'endereco' => 'R. Joao pereira N 199',
                'complemento' => 'Apto 22',
                'cdcard' => Hash::make('5217380805551623', ['rounds' => 12]),
            ]);
        }



    //    DB::table('pedidos')->insert([
    //     'codpedido' => '0001',
    //     'telefone' => '11979698090',
    //     'nome' => 'Joao Silva',
    //     'descricao' => 'Pizza de Calabresa',
    //     'vlunit' => 45.99,
    //     'status' => 'Sendo Preparado',
    //     'fpage' => 'Cartao Credito',
    //     'vltotal' => 45.99,
    //     'endereco' => 'R. Joao pereira N 199',
    //     'complemento' => 'Apto 22',
    //     'cdcard' => Hash::make('5217380805551623', ['rounds' => 12]),
    //    ]);
    }
}
