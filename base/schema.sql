-- id client sequence
CREATE SEQUENCE idclient_seq START 1;

-- Cr�er la table CLIENT en utilisant la s�quence
CREATE TABLE CLIENT (
   idclient VARCHAR(20) DEFAULT 'CL00' || LPAD(nextval('idclient_seq')::TEXT, 4, '0'),
   Birth DATE,
   name VARCHAR(50) ,
   PRIMARY KEY(idclient)
);

CREATE FUNCTION get_idclient()
RETURNS VARCHAR(20)
AS $$
DECLARE
    next_val INTEGER;
    formatted_id VARCHAR(20);
BEGIN
    -- Obtenir la prochaine valeur de la s�quence
    SELECT nextval('idclient_seq') INTO next_val;

    -- Formater l'ID du client
    formatted_id := 'CL00' || LPAD(next_val::TEXT, 4, '0');

    -- Retourner l'ID format�
    RETURN formatted_id;
END;
$$ LANGUAGE plpgsql;


CREATE TABLE STATUS(
   note INTEGER,
   description VARCHAR(50) ,
   PRIMARY KEY(note)
);



-----------Visit ----------------
CREATE SEQUENCE idvisit_seq START 1;

-- Cr�er la table VISIT en utilisant la s�quence
CREATE TABLE VISIT (
   idvisit VARCHAR(20) DEFAULT 'VS00' || LPAD(nextval('idvisit_seq')::TEXT, 4, '0'),
   amount NUMERIC(18,2),
   dates TIMESTAMP NOT NULL,
   idclient VARCHAR(20) NOT NULL,
   PRIMARY KEY(idvisit),
   FOREIGN KEY(idclient) REFERENCES CLIENT(idclient)
);


CREATE OR REPLACE FUNCTION get_idvisit()
RETURNS VARCHAR(20)
AS $$
DECLARE
    next_val INTEGER;
    formatted_id VARCHAR(20);
BEGIN
    -- Obtenir la prochaine valeur de la s�quence
    SELECT nextval('idvisit_seq') INTO next_val;

    -- Formater l'ID de la visite
    formatted_id := 'VS00' || LPAD(next_val::TEXT, 4, '0');

    -- Retourner l'ID format�
    RETURN formatted_id;
END;
$$ LANGUAGE plpgsql;




CREATE TABLE TYPE(
   idtype INTEGER,
   nom VARCHAR(50) ,
   PRIMARY KEY(idtype)   
);
alter  table "type"  add column    idprice integer ;
alter table type add foreign key(idprice) references price(idprice);


-------TOOth---------
CREATE TABLE TOOTH(
   idtooth INTEGER,
	 positions INTEGER,
	idtype INTEGER NOT NULL,
	idprix INTEGER NOT NULL,
	PRIMARY KEY(idtooth),
	FOREIGN KEY(idtype) REFERENCES TYPE(idtype),
	FOREIGN KEY(idprix) REFERENCES PRIX(idprix)
);

-- Cr�er la s�quence pour idhistorique
CREATE SEQUENCE idhistorique_seq START 1;

-- Cr�er la table HISTOIRE en utilisant la s�quence
CREATE TABLE HISTORIQUE (
   idhistorique VARCHAR(50) DEFAULT 'H00' || LPAD(nextval('idhistorique_seq')::TEXT, 4, '0'),
   note INTEGER NOT NULL,
   idtooth INTEGER NOT NULL,
   idvisit VARCHAR(20) NOT NULL,
   PRIMARY KEY(idhistorique),
   FOREIGN KEY(note) REFERENCES STATUS(note),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth),
   FOREIGN KEY(idvisit) REFERENCES VISIT(idvisit)
);

-- Cr�er la s�quence pour idsoin
CREATE SEQUENCE idsoin_seq START 1;

-- Cr�er la table SOIN en utilisant la s�quence
CREATE TABLE SOIN (
   idsoin VARCHAR(50) DEFAULT 'S00' || LPAD(nextval('idsoin_seq')::TEXT, 4, '0'),
   type VARCHAR(50),
   idtooth INTEGER NOT NULL,
   idvisit VARCHAR(20) NOT NULL,
   PRIMARY KEY(idsoin),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth),
   FOREIGN KEY(idvisit) REFERENCES VISIT(idvisit)
);

CREATE TABLE PRIce(
   idprice SERIAL,
   remplacement NUMERIC(18,2)  , // 0
   nettoyage NUMERIC(18,2)  ,    // 1
   enlevement NUMERIC(18,2)  ,   // 2
   reparation NUMERIC(18,2)  ,   // 3 
   PRIMARY KEY(idprice),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth)
);

create table Params (
    soinType int ,
    notemin int ,
    notemax int 
);

-- Cr�er la s�quence pour idsoin
CREATE SEQUENCE idsoin_seq START 1;

-- Cr�er la table SOIN en utilisant la s�quence
CREATE TABLE SOIN (
   idsoin VARCHAR(50) DEFAULT 'S00' || LPAD(nextval('idsoin_seq')::TEXT, 4, '0'),
   type VARCHAR(50),
   idtooth INTEGER NOT NULL,
   idvisit VARCHAR(20) NOT NULL,
   PRIMARY KEY(idsoin),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth),
   FOREIGN KEY(idvisit) REFERENCES VISIT(idvisit)
);