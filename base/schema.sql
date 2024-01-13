-- id client sequence
CREATE SEQUENCE idclient_seq START 1;

-- Créer la table CLIENT en utilisant la séquence
CREATE TABLE CLIENT (
   idclient VARCHAR(20) DEFAULT 'CL00' || LPAD(nextval('idclient_seq')::TEXT, 4, '0'),
   Birth DATE,
   name VARCHAR(50) ,
   PRIMARY KEY(idclient)
);

CREATE TABLE STATUS(
   note INTEGER,
   description VARCHAR(50) ,
   PRIMARY KEY(note)
);
-- id visit sequnce
CREATE SEQUENCE idvisit_seq START 1;

-- Créer la table VISIT en utilisant la séquence
CREATE TABLE VISIT (
   idvisit VARCHAR(20) DEFAULT 'VS00' || LPAD(nextval('idvisit_seq')::TEXT, 4, '0'),
   amount NUMERIC(18,2),
   dates TIMESTAMP NOT NULL,
   idclient VARCHAR(20) NOT NULL,
   PRIMARY KEY(idvisit),
   FOREIGN KEY(idclient) REFERENCES CLIENT(idclient)
);

CREATE TABLE TYPE(
   idtype INTEGER,
   nom VARCHAR(50) ,
   PRIMARY KEY(idtype)
);

CREATE TABLE TOOTH(
   idtooth INTEGER,
   positions INTEGER,
   idtype INTEGER NOT NULL,
   PRIMARY KEY(idtooth),
   FOREIGN KEY(idtype) REFERENCES TYPE(idtype)
);

-- Créer la séquence pour idhistorique
CREATE SEQUENCE idhistorique_seq START 1;

-- Créer la table HISTOIRE en utilisant la séquence
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

-- Créer la séquence pour idsoin
CREATE SEQUENCE idsoin_seq START 1;

-- Créer la table SOIN en utilisant la séquence
CREATE TABLE SOIN (
   idsoin VARCHAR(50) DEFAULT 'S00' || LPAD(nextval('idsoin_seq')::TEXT, 4, '0'),
   type VARCHAR(50),
   idtooth INTEGER NOT NULL,
   idvisit VARCHAR(20) NOT NULL,
   PRIMARY KEY(idsoin),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth),
   FOREIGN KEY(idvisit) REFERENCES VISIT(idvisit)
);

CREATE TABLE PRIX(
   idprix SERIAL,
   remplacement NUMERIC(18,2)  ,
   nettoyage NUMERIC(18,2)  ,
   enlevement NUMERIC(18,2)  ,
   reparation NUMERIC(18,2)  ,
   idtooth INTEGER NOT NULL,
   PRIMARY KEY(idprix),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth)
);

-- Créer la séquence pour idsoin
CREATE SEQUENCE idsoin_seq START 1;

-- Créer la table SOIN en utilisant la séquence
CREATE TABLE SOIN (
   idsoin VARCHAR(50) DEFAULT 'S00' || LPAD(nextval('idsoin_seq')::TEXT, 4, '0'),
   type VARCHAR(50),
   idtooth INTEGER NOT NULL,
   idvisit VARCHAR(20) NOT NULL,
   PRIMARY KEY(idsoin),
   FOREIGN KEY(idtooth) REFERENCES TOOTH(idtooth),
   FOREIGN KEY(idvisit) REFERENCES VISIT(idvisit)
);