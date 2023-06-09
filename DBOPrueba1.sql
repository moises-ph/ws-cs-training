create database bdexamprueba;

use bdexamprueba;

--CREACION DE TABLAS
CREATE TABLE EMPLEADOS(
EMPLEADOID int NOT NULL,
NOMBRE char(30) NULL,
APELLIDO char(30) NULL,
FECHA_NAC date NULL,
REPORTA_A int NULL,
EXTENSION int NULL,
CONSTRAINT PK_EMPLEADOS PRIMARY KEY (EMPLEADOID),
CONSTRAINT FK_EMPLEADO_REPORTA FOREIGN KEY (REPORTA_A) REFERENCES EMPLEADOS(EMPLEADOID)
);
CREATE TABLE PROVEEDORES(
PROVEEDORID int NOT NULL,
NOMBREPROV char(50) NOT NULL,
CONTACTO char(50) NOT NULL,
CELUPROV char(12) NULL,
FIJOPROV char(12) NULL,
CONSTRAINT PK_PROVEEDORES PRIMARY KEY (PROVEEDORID )
);
CREATE TABLE CATEGORIAS(
CATEGORIAID int NOT NULL,
NOMBRECAT char(50) NOT NULL,
CONSTRAINT PK_CATEGORIAS PRIMARY KEY
(CATEGORIAID)
);
CREATE TABLE CLIENTES(
CLIENTEID int NOT NULL,
CEDULA_RUC char(10) NOT NULL,
NOMBRECIA char(30) NOT NULL,
NOMBRECONTACTO char(50) NOT NULL,
DIRECCIONCLI char(50) NOT NULL,
FAX char(12) NULL,
EMAIL char(50) NULL,
CELULAR char(12) NULL,
FIJO char(12) NULL,
CONSTRAINT PK_CLIENTES PRIMARY KEY(CLIENTEID)
);
CREATE TABLE ORDENES(
ORDENID int NOT NULL,
EMPLEADOID int NOT NULL,
CLIENTEID int NOT NULL,
FECHAORDEN date NOT NULL,
DESCUENTO int NULL,
CONSTRAINT PK_ORDENES PRIMARY KEY(ORDENID),
CONSTRAINT FK_ORDENES_CLIEN_ORD_CLIENTES FOREIGN KEY (CLIENTEID) REFERENCES
CLIENTES(CLIENTEID),
CONSTRAINT FK_ORDENES_EMPLE_ORD_EMPLEADO FOREIGN KEY (EMPLEADOID) REFERENCES
EMPLEADOS(EMPLEADOID)
);
CREATE TABLE PRODUCTOS(
PRODUCTOID int NOT NULL,
PROVEEDORID int NOT NULL,
CATEGORIAID int NOT NULL,
DESCRIPCION char(50) NULL,
PRECIOUNIT int NOT NULL,
EXISTENCIA int NOT NULL,
CONSTRAINT PK_PRODUCTOS PRIMARY KEY(PRODUCTOID),
CONSTRAINT FK_PRODUCTO_CATE_PROD_CATEGORI FOREIGN KEY (CATEGORIAID) REFERENCES
CATEGORIAS(CATEGORIAID),
CONSTRAINT FK_PRODUCTO_PROV_PROD_PROVEEDO FOREIGN KEY (PROVEEDORID) REFERENCES
PROVEEDORES(PROVEEDORID)
);
CREATE TABLE DETALLE_ORDENES(
ORDENID int NOT NULL,
DETALLEID int NOT NULL,
PRODUCTOID int NOT NULL,
CANTIDAD int NOT NULL,
CONSTRAINT PK_DETALLE_ORDENES PRIMARY KEY (ORDENID,DETALLEID ),
CONSTRAINT FK_DETALLE__ORDEN_DET_ORDENES FOREIGN KEY (ORDENID) REFERENCES
ORDENES(ORDENID),
CONSTRAINT FK_DETALLE__PROD_DETA_PRODUCTO FOREIGN KEY (PRODUCTOID) REFERENCES
PRODUCTOS(PRODUCTOID)
);
--INSERCION DE DATOS

select * from CATEGORIAS;
select * from CLIENTES;
select * from DETALLE_ORDENES;
select * from EMPLEADOS;
select * from ORDENES;
select * from PRODUCTOS;
select * from PRODUCTOS;

insert into categorias (categoriaid, nombrecat) values (100, 'CARNICOS');
insert into categorias (categoriaid, nombrecat) values (200, 'LACTEOS');
insert into categorias (categoriaid, nombrecat) values (300, 'LIMPIEZA');
insert into categorias (categoriaid, nombrecat) values (400, 'HIGINE PERSONAL');
insert into categorias (categoriaid, nombrecat) values (500, 'MEDICINAS');
insert into categorias (categoriaid, nombrecat) values (600, 'COSMETICOS');
insert into categorias (categoriaid, nombrecat) values (700, 'REVISTAS');

insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(10, 'DON DIEGO', 'MANUEL ANDRADE', '099234567','2124456');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(20, 'PRONACA', 'JUAN PEREZ', '0923434467','2124456');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(30, 'TONY', 'JORGE BRITO', '099234567','2124456');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(40, 'MIRAFLORES', 'MARIA PAZ', '098124498','2458799');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(50, 'ALMAY', 'PEDRO GONZALEZ', '097654567','2507190');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(60, 'REVLON', 'MONICA SALAS', '099245678','2609876');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(70, 'YANBAL', 'BETY ARIAS', '098124458','2450887');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(120, 'JURIS', 'MANUEL ANDRADE', '099234567','2124456');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(80, 'CLEANER', 'MANUEL ANDRADE', '099234567','2124456');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(90, 'BAYER', 'MANUEL ANDRADE', '099234567','2124456');
insert into proveedores (proveedorid, nombreprov, contacto,celuprov,fijoprov) values
(110, 'PALMOLIVE', 'MANUEL ANDRADE', '099234567','2124456');


INSERT INTO PRODUCTOS VALUES (1,10,100,'SALCHICHAS VIENESAS',2.60,200);
INSERT INTO PRODUCTOS VALUES (2,10,100,'SALAMI DE AJO',3.60,300);
INSERT INTO PRODUCTOS VALUES (3,10,100,'BOTON PARA ASADO',4.70,400);
INSERT INTO PRODUCTOS VALUES (4,20,100,'SALCHICHAS DE POLLO',2.90,200);
INSERT INTO PRODUCTOS VALUES (5,20,100,'JAMON DE POLLO',2.80,100);
INSERT INTO PRODUCTOS VALUES (6,30,200,'YOGURT NATURAL',4.30,80);
INSERT INTO PRODUCTOS VALUES (7,30,200,'LECHE CHOCOLATE',1.60,90);
INSERT INTO PRODUCTOS VALUES (8,40,200,'YOGURT DE SABORES',1.60,200);
INSERT INTO PRODUCTOS VALUES (9,40,200,'CREMA DE LECHE',3.60,30);
INSERT INTO PRODUCTOS VALUES (10,50,600,'BASE DE MAQUILLAJE',14.70,40);
INSERT INTO PRODUCTOS VALUES (11,50,600,'RIMMEL',12.90,20);
INSERT INTO PRODUCTOS VALUES (13,60,600,'SOMBRA DE OJOS',9.80,100);

select * from empleados;
INSERT INTO EMPLEADOS VALUES (1,'JUAN', 'CRUZ', '1967-5-18',null, 231);
INSERT INTO EMPLEADOS VALUES (2,'MARIO', 'SANCHEZ', '1979-3-01',1,144);
INSERT INTO EMPLEADOS VALUES (3,'VERONICA', 'ARIAS', '1977-6-23',1, 234);
INSERT INTO EMPLEADOS VALUES (4,'PABLO', 'CELY', '1977-4-28',2, 567);
INSERT INTO EMPLEADOS VALUES (5,'DIEGO', 'ANDRADE', '1970-10-15',2, 890);
INSERT INTO EMPLEADOS VALUES (6,'JUAN', 'ANDRADE', '1976-11-17',3, 230);
INSERT INTO EMPLEADOS VALUES (7,'MARIA', 'NOBOA', '1979-12-21',3, 261);


INSERT INTO CLIENTES VALUES (1,'1890786576','SUPERMERCADO ESTRELLA','JUAN
ALBAN','AV.AMAZONAS',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (2,'1298765477','EL ROSADO','MARIA CORDERO','AV.AEL
INCA',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (3,'1009876567','DISTRIBUIDORA PRENSA','PEDRO PINTO','EL
PINAR',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (4,'1876090006','SU TIENDA','PABLO
PONCE','AV.AMAZONAS',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (5,'1893456776','SUPERMERCADO DORADO','LORENA PAZ','AV.6
DICIEMBRE',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (6,'1678999891','MI COMISARIATO','ROSARIO
UTRERAS','AV.AMAZONAS',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (7,'1244567888','SUPERMERCADO DESCUENTO','LETICIA ORTEGA','AV.LA
PRENSA',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (8,'1456799022','EL DESCUENTO','JUAN
TORRES','AV.PATRIA',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (9,'1845677777','DE LUISE','JORGE
PARRA','AV.AMAZONAS',NULL,NULL,NULL,NULL);
INSERT INTO CLIENTES VALUES (10,'183445667','YARBANTRELLA','PABLO
POLIT','AV.REPUBLICA',NULL,NULL,NULL,NULL);


INSERT INTO ORDENES VALUES(1,3,4,'17-jun-07', 5);
INSERT INTO ORDENES VALUES(2,3,4,'02-jun-07', 10);
INSERT INTO ORDENES VALUES(3,4,5,'05-jun-07', 6);
INSERT INTO ORDENES VALUES(4,2,6,'06-jun-07', 2);
INSERT INTO ORDENES VALUES(5,2,7,'09-jun-07', NULL);
INSERT INTO ORDENES VALUES(6,4,5,'12-jun-07', 10);
INSERT INTO ORDENES VALUES(7,2,5,'14-jun-07', 10);
INSERT INTO ORDENES VALUES(8,3,2,'13-jun-07', 10);
INSERT INTO ORDENES VALUES(9,3,2,'17-jun-07', 3);
INSERT INTO ORDENES VALUES(10,2,2,'18-jun-07', 2);


insert into detalle_ordenes values(1,1,1,2);
insert into detalle_ordenes values(1,2,4,1);
insert into detalle_ordenes values(1,3,6,1);
insert into detalle_ordenes values(1,4,9,1);
insert into detalle_ordenes values(2,1,10,10);
insert into detalle_ordenes values(2,2,13,20);
insert into detalle_ordenes values(3,1,3,10);
insert into detalle_ordenes values(4,1,9,12);
insert into detalle_ordenes values(5,1,1,14);
insert into detalle_ordenes values(5,2,4,20);
insert into detalle_ordenes values(6,1,3,12);
insert into detalle_ordenes values(7,1,11,10);
insert into detalle_ordenes values(8,1,2,10);
insert into detalle_ordenes values(8,2,5,14);
insert into detalle_ordenes values(8,3,7,10);
insert into detalle_ordenes values(9,1,11,10);
insert into detalle_ordenes values(10,1,1,5);

/* Consultas */

/* 1 */
select C.NOMBRECONTACTO, E.EMPLEADOID, E.NOMBRE, O.ORDENID, O.FECHAORDEN ,O.DESCUENTO from CLIENTES C inner join ORDENES O on C.CLIENTEID = O.CLIENTEID join EMPLEADOS E on O.EMPLEADOID = E.EMPLEADOID ORDER BY O.ORDENID

/* 2 */
SELECT P.DESCRIPCION , SUM(D.CANTIDAD) as 'Total' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , AVG(D.CANTIDAD) as 'Promedio' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , MAX(D.CANTIDAD) as 'Mayor' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , MIN(D.CANTIDAD) as 'Menor' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , COUNT(D.CANTIDAD) as Cantidad from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION ORDER BY Cantidad asc

/* Consultas */

/* 1 */
select C.NOMBRECONTACTO, E.EMPLEADOID, E.NOMBRE, O.ORDENID, O.FECHAORDEN ,O.DESCUENTO from CLIENTES C inner join ORDENES O on C.CLIENTEID = O.CLIENTEID join EMPLEADOS E on O.EMPLEADOID = E.EMPLEADOID ORDER BY O.ORDENID

/* 2 */
SELECT P.DESCRIPCION , SUM(D.CANTIDAD) as 'Total' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , AVG(D.CANTIDAD) as 'Promedio' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , MAX(D.CANTIDAD) as 'Mayor' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , MIN(D.CANTIDAD) as 'Menor' from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION

SELECT P.DESCRIPCION , COUNT(D.CANTIDAD) as Cantidad from PRODUCTOS P, DETALLE_ORDENES D where P.PRODUCTOID = D.PRODUCTOID GROUP BY P.DESCRIPCION ORDER BY Cantidad asc

SELECT E.NOMBRE, AVG(O.DESCUENTO) as 'Prom Descuento' from ORDENES O , EMPLEADOS E where O.EMPLEADOID = E.EMPLEADOID GROUP BY E.NOMBRE

SELECT C.CATEGORIAID, C.NOMBRECAT, AVG(P.EXISTENCIA) as 'Prom Existencia', SUM(P.EXISTENCIA) as 'Sum Existencia' from PRODUCTOS P, CATEGORIAS C where P.CATEGORIAID = C.CATEGORIAID GROUP BY C.NOMBRECAT, C.CATEGORIAID

/* 2:30 */

select * from CATEGORIAS
SELECT * FROM PRODUCTOS

/* 3 */


SELECT C.CLIENTEID, C.NOMBRECONTACTO, P.DESCRIPCION, P.PRECIOUNIT, PR.NOMBREPROV FROM CLIENTES C join ORDENES O on O.CLIENTEID = C.CLIENTEID join DETALLE_ORDENES D on D.ORDENID = O.ORDENID right join PRODUCTOS P on P.PRODUCTOID = D.PRODUCTOID join PROVEEDORES PR on P.PROVEEDORID = PR.PROVEEDORID where P.PRECIOUNIT > 4 ORDER BY PR.PROVEEDORID desc

/* 4:50 */

SELECT D.ORDENID ,SUM(D.CANTIDAD * P.PRECIOUNIT) as 'Total' from DETALLE_ORDENES D, PRODUCTOS P where D.PRODUCTOID = P.PRODUCTOID GROUP BY D.ORDENID



create procedure GetAllProducts
as
begin
	SELECT * FROM PRODUCTOS
end