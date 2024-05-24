<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{

    public function up(): void
    {
        Schema::create('pedidos', function (Blueprint $table) {
            $table->id()->primary();
            $table->integer('codpedido');
            $table->string('telefone');
            $table->string('nome');
            $table->string('descricao');
            $table->decimal('vlunit');
            $table->string('status');
            $table->string('fpage');
            $table->decimal('vltotal');
            $table->string('endereco');
            $table->string('complemento');
            $table->string('cdcard');
            $table->timestamps();
        });
        
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::drop('Pedidos');
    }
};
