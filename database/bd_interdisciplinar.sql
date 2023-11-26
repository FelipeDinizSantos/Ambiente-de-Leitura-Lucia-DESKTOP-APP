create database db_biblioteca;
use db_biblioteca;

create table tb_bibliotecaria
(
	id int auto_increment,
    nome varchar(50) not null,
    senha varchar(20) not null,
    constraint pk_bibliotecaria primary key (id),
    constraint un_bibliotecaria unique (nome)
);

create table tb_leitor 
(
	id int not null,
    nome varchar(50) not null,
    telefone varchar(11) not null,
    constraint pk_leitor primary key (id),
    constraint un_leitor unique (nome, telefone)
);

create table tb_emprestimo
(
	id int auto_increment,
    id_leitor int not null,
    dataEmprestimo datetime default current_timestamp() not null,
    dataPrevDevolucao date not null,
    constraint pk_emprestimo primary key (id),
    constraint fk_leitor foreign key (id_leitor) references tb_leitor(id)
);

create table tb_emprestimoDevolucao
(
	id_emprestimo int not null,
    id_leitor int not null,
    constraint pk_emprestimoDevolucao primary key (id_emprestimo, id_leitor),
    constraint fk_emprestimo foreign key (id_emprestimo) references tb_emprestimo(id),
    constraint fk_leitor_emprestimoDevolucao foreign key (id_leitor) references tb_leitor(id)
);

create table tb_categoria
(
	id int auto_increment not null,
    nome char(20) not null,
    constraint pk_categoria primary key (id)
);

create table tb_faixaEtaria
(
	id int auto_increment not null,
    nome char(20) not null,
    constraint pk_faixaEtaria primary key (id)
);

create table tb_livro 
(
	id int auto_increment,
    titulo varchar(100) not null,
    autor varchar(50) not null,
	ISBN char(14),
    editora varchar(50),
    sinopse varchar(1000),
    dataPublicacao date,
    numeroPaginas varchar(12),
    id_faixaEtaria int not null,
    alugado boolean not null,
	constraint pk_livro primary key (id),
    constraint fk_faixaEtaria foreign key (id_faixaEtaria) references tb_faixaEtaria (id)
);

create table tb_livroCategoria
(
	id_livro int not null,
    id_categoria int not null,
    constraint pk_livroCategoria primary key(id_livro, id_categoria),
    constraint fk_livro_livroCategoria foreign key(id_livro) references tb_livro(id),
    constraint fk_categoria_livroCategoria foreign key(id_categoria) references tb_categoria(id)
);

create table tb_emprestimoLivro
(
	id_emprestimo int not null,
    id_livro int not null,
    constraint pk_emprestimoLivro primary key (id_emprestimo, id_livro),
    constraint fk_emprestimo_emprestimoLivro foreign key (id_emprestimo) references tb_emprestimo (id),
    constraint fk_livro foreign key (id_livro) references tb_livro (id)
);