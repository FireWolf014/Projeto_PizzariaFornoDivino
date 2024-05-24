<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;


class Pedido extends Model
{
     
    use HasFactory, Notifiable;

    protected $table = 'pedidos';

   protected $fillable = [
     'codpedido', 
     'telefone',
     'nome',
     'descricao', 
     'vlunit',
     'status',
     'fpage',
     'vltotal',
     'endereco',
     'complemento',
     'cdcard',
   ];

   protected function casts(): array
    {
        return [
            
            'cdcard' => 'hashed',
        ];
    }
}
