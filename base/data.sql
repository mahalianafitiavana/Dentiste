--------Params ------

insert  into params values (0, 0,0);
insert  into params values (1, 8,9);
insert  into params values (2, 1,4);
insert  into params values (3, 5,7);
select  * from price;

-------NOTE / STATUS ----------
insert  into status values (-1, 'mbola tsy nitsiry');
insert  into status values (0, 'niala');
insert  into status values (1, 'potika');
insert  into status values (2, 'potika');
insert  into status values (3, 'potika');
insert  into status values (4, 'potika');
insert  into status values (5, 'lavaka');
insert  into status values (6, 'lavaka');
insert  into status values (7, 'lavaka');
insert  into status values (8, 'maloto');
insert  into status values (9, 'maloto');
insert  into status values (10, 'tsy misy olana');

delete from type;
--------TYPE DE DENTS----------------
INSERT INTO type VALUES
(1, 'Incisive centrale   ',1),
(2, 'Incisive latérale   ',2),
(3, 'Canine   ',3),
(4, 'Première prémolaire   ',4),
(5, 'Deuxième prémolaire   ',5),
(6, 'Première molaire   ',6),
(7, 'Deuxième molaire   ',7),
(8, 'Troisième molaire   ',8);
select  * from "type" t ;


-------PRIX-------------
-- Procédure de remplacement de la molaire supérieure droite
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (1, 150.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la molaire inférieure gauche
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (2, 100.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la canine supérieure centrale
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (3, 200.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la prémolaire inférieure droite
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (4, 150.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la canine inférieure centrale
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (5, 200.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la prémolaire supérieure gauche
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (6, 100.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la prémolaire supérieure droite
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (7, 150.00, 50.00, 200.00, 100.00); 

-- Procédure de remplacement de la prémolaire inférieure gauche
INSERT INTO PRIce (idprice, remplacement, nettoyage, enlevement, reparation)
VALUES (8, 100.00, 50.00, 200.00, 100.00); 


select  * from price;

-------POSITION --------
insert  into tooth values 
(11, 1 ,1 ),
(12, 1 ,2 ),
(13, 1 ,3 ),
(14, 1 ,4 ),
(15, 1 ,5 ),
(16, 1 ,6 ),
(17, 1 ,7 ),
(18, 1 ,8 ) ;
insert  into tooth values 
(21,2,1 ),
(22,2,2 ),
(23,2,3 ),
(24,2,4 ),
(25,2,5 ),
(26,2,6 ),
(27,2,7 ),
(28,2,8 ) ;
insert  into tooth values 
(31,3,1 ),
(32,3,2 ),
(33,3,3 ),
(34,3,4 ),
(35,3,5 ),
(36,3,6 ),
(37,3,7 ),
(38,3,8 ) ;
insert  into tooth values 
(41,4,1 ),
(42,4,2 ),
(43,4,3 ),
(44,4,4 ),
(45,4,5 ),
(46,4,6 ),
(47,4,7 ),
(48,4,8 ) ;
select  * from tooth t ;


