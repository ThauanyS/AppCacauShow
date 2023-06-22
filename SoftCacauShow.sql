create database Soft_CacauShow;
use Soft_CacauShow;

create table Caixa(
id_cai int primary key auto_increment,
data_cai date,
saldo_cai double,
hora_abertura_cai time,
hora_fechamento_cai time,
saldo_final_cai double,
saldo_inicial_cai double
);

create table Cliente(
id_cli int primary key auto_increment,
nome_cli varchar (300),
data_nasc_cli date,
cpf_cli varchar(200),
rg_cli varchar(300),
contato_cli varchar(300),
email_cli varchar(100),
endereco_cli varchar(500),
cep_cli varchar(100),
uf_cli varchar(100),
bairro_cli varchar(100),
municipio_cli varchar(100)
);

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar (100) not null,
data_nasc_fun date  not null,
rg_fun varchar(100)  not null,
cpf_fun varchar(100)  not null,
email_fun varchar(150)  not null,
funcao_fun varchar(100)  not null,
contato_fun varchar(100)  not null,
endereco_fun varchar(500),
cep_fun varchar(100),
uf_fun varchar(100),
bairro_fun varchar(100),
municipio_fun varchar(100)
);

create table Fornecedor(
id_for int primary key auto_increment,
nome_for varchar(300),
email_for varchar(300),
cnpj_for varchar(300),
telefone_for varchar(300),
endereco_for varchar(500),
cep_for varchar(100),
uf_for varchar(100),
bairro_for varchar(100),
municipio_for varchar(100)
);

create table Produto(
id_pro int primary key auto_increment,
nome_pro varchar(300),
codigo_pro varchar(500),
data_venc_pro date,
valor_unit_pro float,
descricao_pro varchar(100)
);

create table Pagamento(
id_pag int primary key auto_increment, 
vencimento_pag date,
valor_pag double,
parcela_pag int,
id_for_fk int not null,
id_cai_fk int not null,
foreign key (id_for_fk) references fornecedor (id_for),
foreign key (id_cai_fk) references caixa (id_cai)
);

create table Venda(
id_ven int primary key auto_increment,
data_ven date,
desconto_ven float,
hora_ven time,
valor_ven float,
parcela_ven double,
form_pag_ven varchar(300),
id_fun_fk int,
foreign key (id_fun_fk) references Funcionario (id_fun),
id_cli_fk int,
foreign key (id_cli_fk) references Cliente (id_cli)
);

create table Recebimento(
id_rec int primary key auto_increment,
vencimento_pag date,
valor_pag double,
parcela_pag int,
id_ven_fk int not null,
id_cai_fk int not null,
foreign key (id_ven_fk) references venda (id_ven),
foreign key (id_cai_fk) references caixa (id_cai)
);

create table Login(
id_log int primary key auto_increment,
hora_log time,
data_log date,
hora_logout_log time,
id_fun_fk int not null,
foreign key (id_fun_fk) references funcionario (id_fun)
);

create table Compra(
id_com int primary key auto_increment,
data_com date,
forma_pag_com varchar(200),
valor_total_com float,
status_com varchar(200),
id_fun_fk int,
foreign key (id_fun_fk) references Funcionario(id_fun),
id_for_fk int,
foreign key (id_for_fk) references Fornecedor(id_for),
id_pro_fk int,
foreign key (id_pro_fk) references Produto(id_pro)
);

create table Produto_Compra(
id_pro_com int primary key auto_increment,
quant_pro_com int,
valor_pro_com float,
id_pro_fk int,
foreign key (id_pro_fk) references Produto (id_pro),
id_com_fk int,
foreign key (id_com_fk) references Compra (id_com)
);

create table Produto_Venda(
id_pro_ven int primary key auto_increment,
valor_pro_ven float,
quant_pro_ven int,
id_pro_fk int,
foreign key (id_pro_fk) references Produto (id_pro),
id_ven_fk int,
foreign key (id_ven_fk) references Venda (id_ven)
);


insert into Produto (id_pro, nome_pro, codigo_pro, data_venc_pro, valor_unit_pro, descricao_pro) values (1, 'Susanne Hatto', '899889899', '2010-02-12', 676765554, '88989899889');
INSERT INTO Fornecedor (id_for, nome_for, email_for, cnpj_for, telefone_for, endereco_for, cep_for, uf_for, bairro_for, municipio_for) VALUES (1, 'CacauShow','ccsw@gmail.com', '11.878.898/0001-11', '(69)98768-5544', 'Av. Mal. Rondon, 1845','76900', 'Rondonia','hjshdh','Municipio');
INSERT INTO Funcionario (id_fun, nome_fun, data_nasc_fun, rg_fun, cpf_fun, email_fun, funcao_fun, contato_fun, endereco_fun, cep_fun, uf_fun, bairro_fun, municipio_fun) 
VALUES (1, 'CacauShow','2005-09-12','893289892','7817389927','ccsw@gmail.com', 'vendedor', '(69)98768-5544', 'Av. Mal. Rondon, 1845','76900', 'Rondonia','hjshdh','Municipio');
INSERT INTO Cliente (id_cli, nome_cli, data_nasc_cli, rg_cli, cpf_cli, email_cli, contato_cli, endereco_cli, cep_cli, uf_cli, bairro_cli, municipio_cli) VALUES (8, 'CacauShow','2005-09-12','893289892','7817389927','ccsw@gmail.com', '(69)98768-5544', 'Av. Mal. Rondon, 1845','76900', 'Rondonia','hjshdh','Municipio');


select * from Cliente;

