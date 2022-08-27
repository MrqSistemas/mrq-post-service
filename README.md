## Usando a migration

Ajuste o package manager para user o Repository como default project e defina o projeto API como startup project, também é necessário remover a declaração <PrivateAssets>all</PrivateAssets> da referência ao pacote Microsoft.EntityFrameworkCore.Design no arquivo de projeto Repository.

Rode pelo package manager:
add-migration inicial
update-database
