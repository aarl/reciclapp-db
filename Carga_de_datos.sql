use reciclapp;
GO

-- Funcion para obtener la version vigente de la API
drop function if exists  dbo.fn_ultima_version_api;
GO

create function fn_ultima_version_api() returns nvarchar(15) AS
begin
    declare @ver nvarchar(15);

    select
        @ver = coalesce(version, '1.0')
    from
        versiones_api
    where 
        vigente_desde = (
            select
        max(vigente_desde)
    from
        versiones_api
        );

    return @ver;
end;

GO

-- Cambiar valores por defecto de la columna api_version en cata tabla
declare cur1 cursor FOR
    select 
        st.name tabla, sdc.name restriccion
    from 
        sys.default_constraints sdc
            join sys.columns sc ON
                sdc.object_id = sc.default_object_id
            join sys.tables st ON
                sc.object_id = st.object_id
    where 
        st.name <> '__EFMigrationsHistory' AND
        sc.name = 'version_api'
    order BY
        st.name;

declare @tabla nvarchar(100), @restriccion nvarchar(100), @inst NVARCHAR(500);

open cur1;
FETCH next from cur1 into @tabla, @restriccion;

while (@@fetch_status = 0)
BEGIN 
    set @inst = concat('alter table ', @tabla, ' drop constraint ', @restriccion);
    exec(@inst);
    FETCH next from cur1 into @tabla, @restriccion;
END;

close cur1
DEALLOCATE cur1;

declare cur2 cursor for
    select 
        table_name 
    from 
        INFORMATION_SCHEMA.TABLES 
    where 
        TABLE_NAME not in ('administradores', '__EFMigrationsHistory');

open cur2;
fetch next from cur2 into @tabla

while (@@FETCH_STATUS = 0)
begin
    set @inst = concat('alter table ', @tabla, ' add constraint DF_', @tabla, '_version_api default (coalesce(dbo.fn_ultima_version_api(), ''1.0'')) for version_api');
    exec(@inst);
    fetch next from cur2 into @tabla;
end;

close cur2;
deallocate cur2;

GO

-- Trigger para actualizar campo 'consecutivo' de la tabla publicaciones
drop trigger if exists dbo.tr_actualizar_consecutivo;
GO

create trigger tr_actualizar_consecutivo on dbo.publicaciones after insert as
begin
    declare @sec bigint;

    begin try
        update secuencias set serie = serie + incremento where prefijo = 'PUB';
        select @sec = coalesce(serie, 1) from secuencias where prefijo = 'PUB';
        update publicaciones set consecutivo = @sec from inserted where publicaciones.id = inserted.id;
    end try
    begin catch
        throw 60001, 'ERR_INSERT_PUBLICACION_ABORTADO', 1;
    end catch;
end;

GO

-- Crear usuario administrador. Admin123
insert into administradores
    (nombre, apellido, telefono, email, clave)
values
    ('admin', 'admin', '555-555-5555', 'admin@reciclapp.com', '3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2');

declare @idusr uniqueidentifier;
select @idusr = id
from administradores;

-- Tablas
insert into tablas
    (id, descripcion, id_creador, id_modificador)
values
    ('T-ADMINS', 'Tabla de administradores', @idusr, @idusr),
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

-- Grupos de usuarios
insert into varios
    (id_tabla, descripcion, id_creador, id_modificador)
values
    ('T-GRPUSR', 'Administradores', @idusr, @idusr),
    ('T-GRPUSR', 'Usuarios', @idusr, @idusr);

declare @idgrpadmin int;
select @idgrpadmin = id
from varios
where id_tabla = 'T-GRPUSR' and descripcion = 'Administradores';

update administradores set id_grupo = @idgrpadmin where id = @idusr;

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

-- Estados
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
    ('T-CIUDADES', 'Puerto Ayacucho	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Amazonas'), @idusr, @idusr),
    ('T-CIUDADES', 'Barcelona', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Anzoátegui'), @idusr, @idusr),
    ('T-CIUDADES', 'San Fernando de Apure	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Apure'), @idusr, @idusr),
    ('T-CIUDADES', 'Maracay	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Aragua'), @idusr, @idusr),
    ('T-CIUDADES', 'Barinas	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Barinas'), @idusr, @idusr),
    ('T-CIUDADES', 'Ciudad Bolívar	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Bolívar'), @idusr, @idusr),
    ('T-CIUDADES', 'Valencia	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Carabobo'), @idusr, @idusr),
    ('T-CIUDADES', 'San Carlos	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Cojedes'), @idusr, @idusr),
    ('T-CIUDADES', 'Tucupita	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Delta Amacuro'), @idusr, @idusr),
    ('T-CIUDADES', 'Caracas	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Distrito Capital'), @idusr, @idusr),
    ('T-CIUDADES', 'Coro	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Falcón'), @idusr, @idusr),
    ('T-CIUDADES', 'San Juan de los Morros	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Guárico'), @idusr, @idusr),
    ('T-CIUDADES', 'La Guaira	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'La Guaira'), @idusr, @idusr),
    ('T-CIUDADES', 'Barquisimeto	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Lara'), @idusr, @idusr),
    ('T-CIUDADES', 'Mérida	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Mérida'), @idusr, @idusr),
    ('T-CIUDADES', 'Los Teques	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Miranda'), @idusr, @idusr),
    ('T-CIUDADES', 'Maturín	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Monagas'), @idusr, @idusr),
    ('T-CIUDADES', 'La Asunción	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Nueva Esparta'), @idusr, @idusr),
    ('T-CIUDADES', 'Guanare	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Portuguesa'), @idusr, @idusr),
    ('T-CIUDADES', 'Cumaná	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Sucre'), @idusr, @idusr),
    ('T-CIUDADES', 'San Cristóbal	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Táchira'), @idusr, @idusr),
    ('T-CIUDADES', 'Trujillo	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Trujillo'), @idusr, @idusr),
    ('T-CIUDADES', 'San Felipe	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Yaracuy'), @idusr, @idusr),
    ('T-CIUDADES', 'Maracaibo	', (select id
        from varios
        where id_tabla = 'T-ESTADOS' and descripcion = 'Zulia'), @idusr, @idusr);

-- Monedas
insert into monedas
    (id, nombre, simbolo, id_creador, id_modificador)
values
    ('MXN', 'México Peso', '$', @idusr, @idusr),
    ('USD', 'EE.UU. Dólar', 'US$', @idusr, @idusr);

-- Secuencias
insert into secuencias (prefijo, id_creador, id_modificador) values ('PUB', @idusr, @idusr);

