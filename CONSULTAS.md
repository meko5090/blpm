ROL-NOMBRE-APELLIDO-USUARIO-CONTRASEÑA
SELECT R.rolename as 'Rol', P.nombre as 'Nombre', P.apellido as 'Apellido', U.username as 'Nombre Usuario', M.password as 'Password'
FROM EDUAR\_DEV.dbo.Personas as P
INNER JOIN  EDUAR\_DEV\_aspnet\_services.dbo.aspnet\_Users as U ON P.username = U.UserName
INNER JOIN  EDUAR\_DEV\_aspnet\_services.dbo.aspnet\_Membership as M ON M.UserId=U.UserId
INNER JOIN EDUAR\_DEV\_aspnet\_services.dbo.aspnet\_UsersInRoles as UR on M.UserId=UR.UserId
INNER JOIN EDUAR\_DEV\_aspnet\_services.dbo.aspnet\_Roles as R on R.RoleId=UR.RoleId
ORDER BY  R.rolename

---


select  DISTINCT CL.nombre as 'Ciclo Lectivo',N.nombre as 'Curso', C.nombre as 'Division', A.nombre as 'Asignatura', PE.apellido as 'Apellido Docente', PE.nombre as 'Nombre Docente'
from DiaHorario as DH
inner join AsignaturaCicloLectivo as ACL on ACL.idAsignaturaCicloLectivo=DH.idAsignaturaCicloLectivo
inner join Personal as P on P.idPersonal=ACL.iddocente
inner join Personas as PE on P.idPersona=PE.idPersona
inner join CursosCicloLectivo as CCL on CCL.idCursoCicloLectivo=ACL.idCursoCicloLectivo
inner join Curso as C on C.idCurso=CCL.idCurso
inner join Nivel as N on N.idNivel =C.idNivel
inner join CicloLectivo as CL on CL.idCicloLectivo=CCL.idCicloLectivo
inner join Asignatura as A on A.idAsignatura=ACL.idAsignatura

---


Select   N.nombre as 'Nivel', C.nombre as 'Division', CL.nombre as 'Año Lectivo',
P.nombre as 'Nombre Alumno', P.apellido as 'Apellido Alumno',ASI.nombre, VEC.valor--
from CursosCicloLectivo as CCL
Inner join Curso as C on CCL.idCurso=C.idCurso
inner join Nivel as N on N.idNivel=C.idnivel
inner join CicloLectivo as CL on CL.idCicloLectivo=CcL.idCicloLectivo
inner join AlumnoCursoCicloLectivo as ACCL on ACCL.idCursoCicloLectivo=CCL.idCursoCicloLectivo
inner Join Alumnos as A on A.idAlumno=ACCL.idAlumno
inner join Personas as P on P.idpersona=A.idpersona
inner join AsignaturaCicloLectivo as ACL on ACL.idCursoCicloLectivo=CCL.idCursoCicloLectivo
inner join Calificacion as Ca on Ca.idAlumnoCursoCicloLectivo=ACCL.idAlumnoCursoCicloLectivo
and Ca.idAsignaturaCicloLectivo=ACL.idAsignatura
inner join Asignatura as ASI on ASI.idAsignatura=ACL.idAsignatura
inner join ValoresEscalaCalificacion as VEC on VEC.idValorEscalaCalificacion=Ca.idValorCalificacion
where N.nombre = '6to Año' and C.nombre='A' and CL.nombre='Ciclo Lectivo 2011'and
Ca.fecha BETWEEN '2011-03-01' and '2012-02-21'

---