-- Crear la base de datos
CREATE DATABASE Cursos;

-- Usar la base de datos
USE cursos;

-- Crear la tabla "alumne"
CREATE TABLE alumne (
  IdAlumne INT PRIMARY KEY AUTO_INCREMENT,
  Nom VARCHAR(50),
  Cognom VARCHAR(50),
  Edat INT
);

-- Crear la tabla "curs"
CREATE TABLE curs (
  IdCurs INT PRIMARY KEY AUTO_INCREMENT,
  Curs VARCHAR(50),
  Any INT,
  Alumnes INT
);

-- Crear la tabla "modul"
CREATE TABLE modul (
  IdModul INT PRIMARY KEY AUTO_INCREMENT,
  Nom VARCHAR(50),
  Uf VARCHAR(50)
);

-- Crear la tabla de relación "relacio"
CREATE TABLE relacio (
  IdAlumne INT,
  IdCurs INT,
  IdModul INT,
  FOREIGN KEY (idAlumne) REFERENCES alumne(idAlumne),
  FOREIGN KEY (IdCurs) REFERENCES curs(IdCurs),
  FOREIGN KEY (IdModul) REFERENCES modul(IdModul)
);
