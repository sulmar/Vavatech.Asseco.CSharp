# Programowanie w C#
Przykłady ze szkolenia C# dla firmy Asseco w Bydgoszczy.

Szkolenie ukierowane było na zastosowanie języka C# do pisania automatycznych testów regresyjnych w środowisku
[Ranorex](http://www.ranorex.com).


## Ranorex
Przykład działania testów utworzonych podczas szkolenia:
[![Watch the video](http://img.youtube.com/vi/gNr297r7gPU/0.jpg)](https://youtu.be/gNr297r7gPU)


## Skrypty
Utworzenie struktury do przechowywania przypadków testowych

~~~ sql

create table tst_calculationData
(
consumtion varchar2(255),
rate varchar2(255),
expected varchar2(255)
)

~~~

Przykładowe przypadki testowe:
~~~ sql
insert into tst_calculationData values ('100','0.1','10.00');
insert into tst_calculationData values ('54','0.3','16.20');
insert into tst_calculationData values ('0.5','0.1','0.05');
insert into tst_calculationData values ('0','2.4','0.00');
insert into tst_calculationData values ('-1','0.2','-0.20');
commit;
~~~~
