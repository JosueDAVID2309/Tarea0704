create database TareaCShard
use TareaCShard

create table Usuarios(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nombres VARCHAR(50) NOT NULL,
	apellidos VARCHAR(60) NOT NULL,
	usuarios VARCHAR(30) NOT NULL,
	genero CHAR(1) NOT NULL,
	f_nacimiento DATE NOT NULL,
	dni CHAR(8) UNIQUE NOT NULL,
	correo VARCHAR(50) UNIQUE NOT NULL,
	contraseña VARCHAR(40) NOT NULL
);

INSERT INTO Usuarios (nombres, apellidos, usuarios, genero, f_nacimiento, dni, correo, contraseña) VALUES 
('Carlos', 'Ramírez Torres', 'carlosr', 'M', '1998-05-14', '60451263' , 'carlos.ramirez@gmail.com', 'pass123'),
('Lucía', 'Fernández Gómez', 'luciaf', 'F', '2001-09-22', '74653215' , 'lucia.fernandez@gmail.com', 'secure456')

CREATE PROCEDURE sp_registrar
@nombres VARCHAR(50),
@apellidos VARCHAR(60),
@usuarios VARCHAR(30),
@genero CHAR(1),
@f_nacimiento DATE,
@dni CHAR(8),
@correo VARCHAR(50),
@contraseña VARCHAR(40)
as insert into Usuarios (nombres, apellidos, usuarios, genero, f_nacimiento, dni, correo, contraseña) VALUES
(@nombres, @apellidos, @usuarios, @genero, @f_nacimiento, @dni, @correo, @contraseña)
GO

CREATE PROCEDURE verificarUsuario
@correo VARCHAR(50),
@contraseña VARCHAR(40)
as SELECT * FROM Usuarios WHERE correo = @correo AND @contraseña = contraseña
GO

CREATE PROCEDURE obtenerUsuarioCorreo
@correo VARCHAR(50)
as SELECT * FROM Usuarios WHERE correo = @correo
GO
