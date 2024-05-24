<?php

namespace Database\Seeders;

use App\Models\Cliente;
use Illuminate\Database\Seeder;

class ClienteSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        if(!Cliente::where('email', 'Joao1450@gmail.com')->first()){
            Cliente::create([
                'nome' => 'Joao Silva',
                'endereco' => 'R. Joao pereira N 199',
                'telefone' => '11979698090',
                'complemento' => 'Apto 22',
                'email' => 'Joao.silva1450@gmail.com',
                'cep' => '05074-070',
            ]);


        //  DB::table('clientes')->insert([
        //     'nome' => 'Joao Silva',
        //     'endereco' => 'R. Joao pereira N 199',
        //     'telefone' => '11979698090',
        //     'complemento' => 'Apto 22',
        //     'email' => 'Joao.silva1450@gmail.com',
        //     'cep' => '05074-070',
        //  ]);
             

        
        }
    }
}