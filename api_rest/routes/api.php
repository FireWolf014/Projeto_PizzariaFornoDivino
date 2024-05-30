<?php

use App\Http\Controllers\Api\ClienteController as ApiClienteController;
use App\Http\Controllers\Api\PedidoController;
use App\Http\Controllers\Api\UserController;
use Illuminate\Support\Facades\Route;


// Rotas Usuarios
Route::get('/users', [UserController::class, 'index']); // GET all http://127.0.0.1:8000/api/users
Route::get('/users/{user}', [UserController::class, 'show']); //GET id http://127.0.0.1:8000/api/users/1
Route::post('/users', [UserController::class, 'store']); //POST http://127.0.0.1:8000/api/users
Route::put('/users/{user}', [UserController::class, 'update']); //PUT http://127.0.0.1:8000/api/users/1
Route::delete('/users/{user}', [UserController::class, 'destroy']); //DELETE http://127.0.0.1:8000/api/users/1



// Rotas Clients
Route::get('/clientes', [ApiClienteController::class, 'index']); //GET all http://127.0.0.1:8000/api/clientes
Route::get('/clientes/{cliente}', [ApiClienteController::class, 'show']); //GET id http://127.0.0.1:8000/api/clientes/1
Route::post('/clientes', [ApiClienteController::class, 'store']); // POST http://127.0.0.1:8000/api/clientes
Route::put('/clientes/{cliente}', [ApiClienteController::class, 'update']); //PUT http://127.0.0.1:8000/api/clientes/1
Route::delete('/clientes/{cliente}', [ApiClienteController::class, 'destroy']); //DELETE http://127.0.0.1:8000/api/users/1

// Rotas Pedidos
Route::get('/pedidos', [PedidoController::class, 'index']); //GET all http://127.0.0.1:8000/api/pedidos
Route::get('/pedidos/{pedido}', [PedidoController::class, 'show']); //GET id http://127.0.0.1:8000/api/pedidos/1
Route::post('/pedidos', [PedidoController::class, 'store']); // POST http://127.0.0.1:8000/api/pedidos
Route::put('/pedidos/{pedido}', [PedidoController::class, 'update']); //PUT http://127.0.0.1:8000/api/pedidos/1
Route::delete('/pedidos/{pedido}', [PedidoController::class, 'destroy']); //DELETE http://127.0.0.1:8000/api/pedidos/1