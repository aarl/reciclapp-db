-- Admin123
insert into 
    usuarios
    (nombre, telefono, email, clave)
values
    ('admin', '04140593302', 'admin@reciclapp.com', '3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2');

-- Tablas
declare @idusr uniqueidentifier;
select @idusr = id
from usuarios;

insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ACTVPRY', 'Tabla de actividades por proyecto', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ACTRTPRY', 'Tabla de actividades por ruta de proyecto', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-BITACPRY', 'Tabla de bitacora por proyecto', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-CHATS', 'Tabla de chats', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-CIUDADES', 'Tabla de ciudades', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-CLSPUBS', 'Tabla de clases de publicación', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-COMENTS', 'Tabla de comentarios por chat', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ESTADOS', 'Tabla de estados', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ESTATPRY', 'Tabla de estatus de proyectos', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ESTATPUB', 'Tabla de estatus de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ESTATREC', 'Tabla de estatus de recursos de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-FASESPUB', 'Tabla de fases de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-GRPUSR', 'Tabla de grupos de usuarios', @idusr, @idusr);
insert into tablas
    (id, descripcion, Id_creador, id_modificador)
VALUES
    ('T-MONEDAS', 'Tabla de monedas', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PAISES', 'Tabla de países', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PERSONAL', 'Tabla de personal asignado por publicación', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PROFSN', 'Tabla de profesiones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PROYECTO', 'Tabla de proyectos', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PUBS', 'Tabla de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-RASTRPUB', 'Tabla de rastreo de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-RECURPUB', 'Tabla de recursos por publicación', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ROLES', 'Tabla de roles', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-RUTASPRY', 'Tabla de rutas de proyectos', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-SECUEN', 'Tabla de secuencias', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TABLAS', 'Lista de tablas de la aplicación', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TIPOSACT', 'Tabla de tipos de actividads', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TIPBITAC', 'Tabla de tipos de bitácoras de proyectos', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TIPOSCAT', 'Tabla de tipos de catalogos', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TIPOSPUB', 'Tabla de tipos de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TIPOSREC', 'Tabla de tipos de recursos de publicaciones', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TIPOSUSR', 'Tabla de tipos de usuarios', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-USUARIOS', 'Tabla de usurios', @idusr, @idusr);
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-VARIOS', 'Varias tablas con la misma estructura', @idusr, @idusr);


-- Geografía
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-PAISES', 'Venezuela', null);
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-PAISES', 'México', null);

declare @idpais int;
select @idpais = id
from varios
where id_tabla = 'T-PAISES' and descripcion = 'Venezuela';

insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Amazonas', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Anzoátegui', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Apure', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Aragua', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Barinas', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Bolívar', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Carabobo', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Cojedes', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Delta Amacuro', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Falcón', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Guárico', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'La Guaira', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Lara', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Mérida', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Miranda', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Monagas', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Nueva Esparta', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Portuguesa', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Sucre', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Táchira', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Trujillo', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Yaracuy', @idpais)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-ESTADOS', 'Zulia', @idpais)

-- Grupos de usuarios
insert into varios
    (id_tabla, descripcion)
values
    ('T-GRPUSR', 'Administradores');
insert into varios
    (id_tabla, descripcion)
values
    ('T-GRPUSR', 'Usuarios');


-- Ciudades
declare @idestado INT
select @idestado = id
from varios
where id_tabla = 'T-ESTADOS' and descripcion = 'aragua';
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-CIUDADES', 'Maracay', @idestado)
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-CIUDADES', 'Turmero', @idestado)

select @idestado = id
from varios
where id_tabla = 'T-ESTADOS' and descripcion = 'falcón';
insert into varios
    (id_tabla, descripcion, id_padre)
values
    ('T-CIUDADES', 'Judibana', @idestado)

