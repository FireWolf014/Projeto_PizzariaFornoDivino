<?php

namespace Database\Seeders;

use App\Models\User;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\Hash;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        if(!User::where('email', 'admin@pizzaria.com.br')->first()){
            User::create([
                'name' => 'Administrador',
                'email' => 'admin@pizzaria.com.br',
                'tipe' => 'admin',
                'password' => Hash::make('Pizarriahuts5533', ['rounds' => 12]),
            ]);
        }
    }
}
