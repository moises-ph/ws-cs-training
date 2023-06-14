create database bduniversidad;

use bduniversidad;

create table Estudiantes(
	IdE int primary key,
	NombreCompleto varchar(200) not null,
	Edad int not null,
	Direccion varchar(300) not null
);

create table Programa(
	IdP int identity(0,1) primary key,
	NombrePrograma varchar(100) not null,
	Descripcion varchar(300) not null,
	Semestres int not null
);

create table Materias(
	IdM int identity(0,1) primary key,
	NombreMateria varchar(100) not null,
	Credito int not null,
	Valor float not null
);

create table Matriculas(
	IdMat int identity(0,1) primary key,
	fecha date default GETDATE(),
	estudianteId int,
	programaId int
);

alter table Matriculas add constraint fk_estudiante_matr foreign key (estudianteId) references Estudiantes(IdE);
alter table Matriculas add constraint fk_programa_matr foreign key (programaId) references Programa(IdP);

create table DetalleMatricula(
	matriculaId int,
	materiaId int
);

alter table DetalleMatricula add constraint fk_matricula_detalle foreign key (matriculaId) references Matriculas(IdMat);
alter table DetalleMatricula add constraint fk_materia_detalle foreign key (materiaId) references Materias(IdM);

create procedure GetAllEstudiantes as begin SELECT * FROM Estudiantes end

create procedure AddEstudent(
	@IdE int,
	@NombreCompleto varchar(200),
	@Edad int,
	@Direccion varchar(300)
)
as
begin 
	INSERT into Estudiantes(IdE, NombreCompleto, Edad, Direccion) values (@IdE, @NombreCompleto, @Edad, @Direccion)
end

execute AddEstudent  1023523155 , 'Moisés Pineda', 18, 'Yulima'

execute GetAllEstudiantes


create procedure UpdateEstudent(
	@IdE int,
	@NombreCompleto varchar(200),
	@Edad int,
	@Direccion varchar(300)
)
as
begin 
	Update Estudiantes set NombreCompleto = @NombreCompleto, Edad = @Edad, Direccion = @Direccion where IdE = @Ide
end

create procedure CreatePrograma(
	@Nombre varchar(100),
	@Descripcion varchar(300),
	@Semestres int
)
as
begin
	INSERT INTO Programa(NombrePrograma, Descripcion, Semestres) values (@Nombre, @Descripcion, @Semestres);
end

create procedure UpdatePrograma(
	@Id int, 
	@Nombre varchar(100),
	@Descripcion varchar(300),
	@Semestres int
)
as
begin
	Update Programa set NombrePrograma = @Nombre, Descripcion = @Descripcion, Semestres = @Semestres where IdP = @Id;
end