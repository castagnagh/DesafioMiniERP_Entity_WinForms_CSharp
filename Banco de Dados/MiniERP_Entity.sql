create database miniERP_Entity;
use miniERP_Entity;

create login usuario with password='senha123';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

select * from Notas;
select * from ClientesProdutos;

SELECT * FROM Clientes

delete from ClientesProdutos
delete from Notas;