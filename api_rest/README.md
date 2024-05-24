##

* PHP 8.2 ou superior
* Mariadb ou MySQL 8 ou superior
* Composer

## Como rodar o projeto baixado



## Sequencia para criar o projeto
Criar o projeto com Laravel
---
composer create-project laravel/laravel .
----

Alterar no arquivo .env as credenciais do banco de dados <br>

Criar o arquivo de rotas para API
---

php artisan install:api
---

## Como rodar o projeto baixado

Duplicar o arquivo ".env.example" e renomear para ".env".<br>
Alterar no arquivo .env as credenciais do banco de dados<br>

Instalar as dependências do PHP
---

Composer install
---

Gerar a chave no arquivo .env
---

php artisan key:generate
---

Executar as seed
---

php artisan db:seed
---

Para acesar a api, é recomendado utilizar o Insomnia ou Postman para simular requisições à API.
---

http://127.0.0.1:8000/api/users
---

