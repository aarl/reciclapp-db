insert into 
    administradores
    (nombre, telefono, email, clave, id_grupo)
values
    ('admin', '04144614216', 'admin@reciclapp.com', '3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2', null);

select *
from administradores;

insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PAISES', 'Tabla de países', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ESTADOS', 'Tabla de estados', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-CIUDADES', 'Tabla de ciudades', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-GRPUSR', 'Tabla de grupos de usuarios', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ACTPRY', 'Tabla de actividades por proyecto', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ACTRTPRY', 'Tabla de actividades por ruta de proyecto', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ADMINS', 'Tabla de administradores', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-BITACPRY', 'Tabla de bitacora por proyecto', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-CHATS', 'Tabla de chats', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-COMENTS', 'Tabla de comentarios por chat', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PERSONAL', 'Tabla de personal asignado por publicación', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PROYECTO', 'Tabla de proyectos', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-PUBS', 'Tabla de publicaciones', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-RASTRPUB', 'Tabla de rastreo de publicaciones', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-RECURPUB', 'Tabla de recursos por publicación', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-SECUENS', 'Tabla de secuencias', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-TABLAS', 'Tabla de tablas de la aplicación', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-USUARIOS', 'Tabla de usurios', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-VARIOS', 'Varias tablas con la misma estructura', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4', '135d7f81-0b3e-4176-aef6-c07b9d5d60a4');
