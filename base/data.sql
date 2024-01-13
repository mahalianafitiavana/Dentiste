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

--------TYPE DE DENTS----------------
INSERT INTO type (idtype, nom) VALUES
(1, 'Incisive centrale   '),
(2, 'Incisive latérale   '),
(3, 'Canine   '),
(4, 'Première prémolaire   '),
(5, 'Deuxième prémolaire   '),
(6, 'Première molaire   '),
(7, 'Deuxième molaire   '),
(8, 'Troisième molaire   ');

-------LES DENTS --------
CREATE TABLE TOOTH(
   idtooth INTEGER,
   positions INTEGER,
   name VARCHAR(50) ,
   idtype INTEGER NOT NULL,
   idprix INTEGER NOT NULL,
   PRIMARY KEY(idtooth),
   FOREIGN KEY(idtype) REFERENCES type(idtype),
   FOREIGN KEY(idprix) REFERENCES PRICE(idprix)
);