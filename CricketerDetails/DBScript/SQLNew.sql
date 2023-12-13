Create table CricketerDetails
(
CricketerId bigint primary key identity(1,1),
CricketerName nvarchar(50) not null,
TotalODI bigint not null, 
TotalScore bigint not null,
Fifties bigint not null,
Hundreds bigint not null
)
select * from CricketerDetails
DROP table CricketerDetails


--TO INSERT
go
Create PROCEDURE
InsertSP(
@CricketerName nvarchar(50), @TotalODI bigint,@TotalScore bigint ,@Fifties bigint,@Hundreds bigint)
as
begin
Insert into CricketerDetails values(@CricketerName, @TotalODI, @TotalScore, @Fifties, @Hundreds)
end
exec InsertSP 'rohit',262,10709,55,31
exec InsertSP 'virat',268,12789,55,50
exec InsertSP 'dhoni',280,9788,45,20


select * from CricketerDetails


--TO UPDATE
go
Create procedure UpdateSP(
@CricketerId bigint ,@CricketerName nvarchar(50), @TotalODI bigint,@TotalScore bigint ,@Fifties bigint,@Hundreds bigint)
as
begin
Update CricketerDetails set CricketerName=@CricketerName, TotalODI=@TotalODI, TotalScore=@TotalScore, Fifties=@Fifties,Hundreds=@Hundreds 
where CricketerId=@CricketerId
end
exec UpdateSP 3,'dhoni',290,9876,30,21

select * from CricketerDetails

--TO READ
go
create procedure ReadSP
as
begin
select * from CricketerDetails
end
exec ReadSP

--TO DELETE
go
create procedure DeleteSP(@CricketerId bigint)
as
begin
delete CricketerDetails  where CricketerId=@CricketerId
end
exec DeleteSP 3
