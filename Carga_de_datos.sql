-- Admin123
insert into administradores
    (nombre, apellido, telefono, email, clave)
values
    ('admin', 'admin', '04140593302', 'admin@reciclapp.com', '3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2');

declare @idusr uniqueidentifier;
select @idusr = id
from administradores;

-- Tablas
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ACTVPRY', 'Tabla de actividades por proyecto', @idusr, @idusr),
    ('T-ACTRTPRY', 'Tabla de actividades por ruta de proyecto', @idusr, @idusr),
    ('T-BITACPRY', 'Tabla de bitacora por proyecto', @idusr, @idusr),
    ('T-CHATS', 'Tabla de chats', @idusr, @idusr),
    ('T-CIUDADES', 'Tabla de ciudades', @idusr, @idusr),
    ('T-CLSPUBS', 'Tabla de clases de publicación', @idusr, @idusr),
    ('T-COMENTS', 'Tabla de comentarios por chat', @idusr, @idusr),
    ('T-ESTADOS', 'Tabla de estados', @idusr, @idusr),
    ('T-ESTATPRY', 'Tabla de estatus de proyectos', @idusr, @idusr),
    ('T-ESTATPUB', 'Tabla de estatus de publicaciones', @idusr, @idusr),
    ('T-ESTATREC', 'Tabla de estatus de recursos de publicaciones', @idusr, @idusr),
    ('T-FASESPUB', 'Tabla de fases de publicaciones', @idusr, @idusr),
    ('T-GRPUSR', 'Tabla de grupos de usuarios', @idusr, @idusr),
    ('T-MONEDAS', 'Tabla de monedas', @idusr, @idusr),
    ('T-PAISES', 'Tabla de países', @idusr, @idusr),
    ('T-PERSONAL', 'Tabla de personal asignado por publicación', @idusr, @idusr),
    ('T-PROFSN', 'Tabla de profesiones', @idusr, @idusr),
    ('T-PROYECTO', 'Tabla de proyectos', @idusr, @idusr),
    ('T-PUBS', 'Tabla de publicaciones', @idusr, @idusr),
    ('T-RASTRPUB', 'Tabla de rastreo de publicaciones', @idusr, @idusr),
    ('T-RECURPUB', 'Tabla de recursos por publicación', @idusr, @idusr),
    ('T-ROLES', 'Tabla de roles', @idusr, @idusr),
    ('T-RUTASPRY', 'Tabla de rutas de proyectos', @idusr, @idusr),
    ('T-SECUEN', 'Tabla de secuencias', @idusr, @idusr),
    ('T-TABLAS', 'Lista de tablas de la aplicación', @idusr, @idusr),
    ('T-TIPOSACT', 'Tabla de tipos de actividads', @idusr, @idusr),
    ('T-TIPBITAC', 'Tabla de tipos de bitácoras de proyectos', @idusr, @idusr),
    ('T-TIPOSCAT', 'Tabla de tipos de catalogos', @idusr, @idusr),
    ('T-TIPOSPUB', 'Tabla de tipos de publicaciones', @idusr, @idusr),
    ('T-TIPOSREC', 'Tabla de tipos de recursos de publicaciones', @idusr, @idusr),
    ('T-TIPOSUSR', 'Tabla de tipos de usuarios', @idusr, @idusr),
    ('T-USUARIOS', 'Tabla de usurios', @idusr, @idusr),
    ('T-VARIOS', 'Varias tablas con la misma estructura', @idusr, @idusr);

-- Tipos de usuarios
insert into varios
    (id_tabla, descripcion, id_creador, id_modificador)
values
    ('T-TIPOSUSR', 'Normal', @idusr, @idusr),
    ('T-TIPOSUSR', 'Verificado', @idusr, @idusr);

-- Paises
insert into varios
    (id_tabla, descripcion, id_padre, id_creador, id_modificador)
values
    ('T-PAISES', 'Venezuela', null, @idusr, @idusr),
    ('T-PAISES', 'México', null, @idusr, @idusr),
    ('T-PAISES', 'Estados Unidos de América', null, @idusr, @idusr);

declare @idpais int;
select @idpais = id
from varios
where id_tabla = 'T-PAISES' and descripcion = 'Venezuela';

insert into varios
    (id_tabla, descripcion, id_padre, id_creador, id_modificador)
values
    ('T-ESTADOS', 'Amazonas', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Anzoátegui', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Apure', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Aragua', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Barinas', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Bolívar', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Carabobo', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Cojedes', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Delta Amacuro', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Falcón', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Guárico', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'La Guaira', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Lara', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Mérida', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Miranda', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Monagas', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Nueva Esparta', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Portuguesa', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Sucre', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Táchira', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Trujillo', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Yaracuy', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Zulia', @idpais, @idusr, @idusr),
    ('T-ESTADOS', 'Distrito Capital', @idpais, @idusr, @idusr);

-- Ciudades
insert into varios 
    (id_tabla, descripcion, id_padre, id_creador, id_modificador)
values
	('T-CIUDADES', 'Puerto Ayacucho	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Amazonas'), @idusr, @idusr),
    ('T-CIUDADES', 'Barcelona', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Anzoátegui'), @idusr, @idusr),
    ('T-CIUDADES', 'San Fernando de Apure	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Apure'), @idusr, @idusr),
    ('T-CIUDADES', 'Maracay	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Aragua'), @idusr, @idusr),
    ('T-CIUDADES', 'Barinas	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Barinas'), @idusr, @idusr),
    ('T-CIUDADES', 'Ciudad Bolívar	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Bolívar'), @idusr, @idusr),
    ('T-CIUDADES', 'Valencia	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Carabobo'), @idusr, @idusr),
    ('T-CIUDADES', 'San Carlos	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Cojedes'), @idusr, @idusr),
    ('T-CIUDADES', 'Tucupita	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Delta Amacuro'), @idusr, @idusr),
    ('T-CIUDADES', 'Caracas	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Distrito Capital'), @idusr, @idusr),
    ('T-CIUDADES', 'Coro	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Falcón'), @idusr, @idusr),
    ('T-CIUDADES', 'San Juan de los Morros	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Guárico'), @idusr, @idusr),
    ('T-CIUDADES', 'La Guaira	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'La Guaira'), @idusr, @idusr),
    ('T-CIUDADES', 'Barquisimeto	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Lara'), @idusr, @idusr),
    ('T-CIUDADES', 'Mérida	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Mérida'), @idusr, @idusr),
    ('T-CIUDADES', 'Los Teques	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Miranda'), @idusr, @idusr),
    ('T-CIUDADES', 'Maturín	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Monagas'), @idusr, @idusr),
    ('T-CIUDADES', 'La Asunción	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Nueva Esparta'), @idusr, @idusr),
    ('T-CIUDADES', 'Guanare	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Portuguesa'), @idusr, @idusr),
    ('T-CIUDADES', 'Cumaná	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Sucre'), @idusr, @idusr),
    ('T-CIUDADES', 'San Cristóbal	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Táchira'), @idusr, @idusr),
    ('T-CIUDADES', 'Trujillo	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Trujillo'), @idusr, @idusr),
    ('T-CIUDADES', 'San Felipe	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Yaracuy'), @idusr, @idusr),
    ('T-CIUDADES', 'Maracaibo	', (select id from varios where id_tabla = 'T-ESTADOS' and descripcion = 'Zulia'), @idusr, @idusr);

-- Grupos de usuarios
insert into varios
    (id_tabla, descripcion, id_creador, id_modificador)
values
    ('T-GRPUSR', 'Administradores', @idusr, @idusr),
    ('T-GRPUSR', 'Usuarios', @idusr, @idusr);

-- Usuarios
insert into 
    usuarios (nombre, apellido, email, id_ciudad, id_grupo, id_tipo_usuario, id_creador, id_modificador)
values
    ('Abraham', 'Simpson', 'abraham_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Agnes', 'Skinner', 'agnes_skinner@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Akira', 'Kurosawa', 'akira_kurosawa@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Apu', 'Nahasapeemapetilon', 'apu_nahasapeemapetilon@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Artie', 'Ziff', 'artie_ziff@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Barney', 'Gumble', 'barney_gumble@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Bart', 'Simpson', 'bart_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Bernice', 'Hibbert', 'bernice_hibbert@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Bob', 'Pati', 'bob_pati@thesimpsons.comño', 110, 99, 70, @idusr, @idusr),
    ('Brandine', 'Spuckler', 'brandine_spuckler@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Carl', 'Carlson', 'carl_carlson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Montgomery', 'Burns', 'charlesmontgomery_burns@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Clancy', 'Wiggum', 'clancy_wiggum@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Cletus', 'Spuckler', 'cletus_spuckler@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Cookie', 'Kwan', 'cookie_kwan@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Dolph', 'Starbeam', 'dolph_starbeam@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Drederick', 'Tatum', 'drederick_tatum@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Edna', 'Krabappel', 'edna_krabappel@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Gary', 'Chalmers', 'gary_chalmers@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Gil', 'Gunderson', 'gil_gunderson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Helen', 'Lovejoy', 'helen_lovejoy@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Homer', 'Simpson', 'homer_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Hyman', 'Krustofsky', 'hyman_krustofsky@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Jacqueline', 'Bouvier', 'jacqueline_bouvier@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Jessica', 'Lovejoy', 'jessica_lovejoy@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Jimbo', 'Jones', 'jimbo_jones@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Joe', 'Quimby', 'joe_quimby@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Julius', 'Hibbert', 'julius_hibbert@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Kearney', 'Zzyzwicz', 'kearney_zzyzwicz@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Kent', 'Brockman', 'kent_brockman@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Kirk', 'Van', 'kirk_van@thesimpsons.com Houten', 110, 99, 70, @idusr, @idusr),
    ('Lenny', 'Leonard', 'lenny_leonard@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Lindsey', 'Naegle', 'lindsey_naegle@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Lionel', 'Hutz', 'lionel_hutz@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Lisa', 'Simpson', 'lisa_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Luann', 'Van', 'luann_van@thesimpsons.com Houten', 110, 99, 70, @idusr, @idusr),
    ('Luigi', 'Risotto', 'luigi_risotto@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Maggie', 'Simpson', 'maggie_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Manjula', 'Nahasapeemapetilon', 'manjula_nahasapeemapetilon@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Marge', 'Simpson', 'marge_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Martin', 'Prince', 'martin_prince@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Marvin', 'Monroe', 'marvin_monroe@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Maude', 'Flanders', 'maude_flanders@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Mel', 'Pati', 'mel_pati@thesimpsons.comño', 110, 99, 70, @idusr, @idusr),
    ('Milhouse', 'Van', 'milhouse_van@thesimpsons.com Houten', 110, 99, 70, @idusr, @idusr),
    ('Moe', 'Szyslak', 'moe_szyslak@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Mona', 'Simpson', 'mona_simpson@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Ned', 'Flanders', 'ned_flanders@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Nelson', 'Muntz', 'nelson_muntz@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Nick', 'Riviera', 'nick_riviera@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Otto', 'Mann', 'otto_mann@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Patty', 'Bouvier', 'patty_bouvier@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Jonathan', 'Frink', 'jonathan_frink@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Rainier', 'Wolfcastle', 'rainier_wolfcastle@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Ralph', 'Wiggum', 'ralph_wiggum@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Rod', 'Flanders', 'rod_flanders@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Sarah', 'Wiggum', 'sarah_wiggum@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Selma', 'Bouvier', 'selma_bouvier@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Seymour', 'Skinner', 'seymour_skinner@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Snake', 'Jailbird', 'snake_jailbird@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Timothy', 'Lovejoy', 'timothy_lovejoy@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Todd', 'Flanders', 'todd_flanders@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Tony', 'D''Amico',	'tony_damico@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Troy', 'McClure', 'troy_mcClure@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Üter', 'Zörker', 'ter_z@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Waylon', 'Smithers', 'waylon_smithers@thesimpsons.com', 110, 99, 70, @idusr, @idusr),
    ('Willie', 'McDougall', 'willie_mcDougall@thesimpsons.com', 110, 99, 70, @idusr, @idusr);
