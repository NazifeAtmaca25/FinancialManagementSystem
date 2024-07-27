create proc login_sp
(
@UserId varchar(50),
@Pasword varchar(50)
)
as
begin
 select count(*) from loginTable where @UserId=UserId and @Pasword=Pasword
end