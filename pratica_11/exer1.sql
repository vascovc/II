insert into dados_alunos (nome, numero_mecanografico, telefone) values ('João Silva', 98451, 965244664);

insert into dados_alunos (nome, numero_mecanografico, telefone) values
('João Silva', 98451, 965244644),
('Sandra Santos', 98745, 945678463),
('Miguel Costa', 97486, 917356356);

select * from dados_alunos;

select nome, numero_mecanografico from dados_alunos;

select distinct(nome) from dados_alunos;
select max(numero_mecanografico) from dados_alunos;

select nome, numero_mecanografico from dados_alunos order by numero_mecanografico desc limit 2;

update dados_alunos set nome = 'João Coelho Silva' where id = 1;

delete from dados_alunos where id = 1;

insert into dados_alunos(nome,numero_mecanografico,telefone) values
('Maria',95876,912456869),
('José',94335,913548666),
('Ana',93568,961548668),
('Luis',96315,915483584),
('Ricardo',94666,933547895);

select * 
from dados_alunos
where numero_mecanografico = 
(select min(numero_mecanografico) from dados_alunos);

update dados_alunos set nome = 'Maria Jose' 
where id=2;

delete dados_alunos from dados_alunos
join (select max(numero_mecanografico) as max_num 
from dados_alunos 
) as max_num where dados_alunos.numero_mecanografico=max_num;



