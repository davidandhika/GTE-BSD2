DROP TABLE DETAIL_MASUK CASCADE CONSTRAINT;
DROP TABLE TRANS_MASUK CASCADE CONSTRAINT;
DROP TABLE TIPE CASCADE CONSTRAINT;
DROP TABLE BRAND CASCADE CONSTRAINT;
DROP TABLE BARANG CASCADE CONSTRAINT;
DROP TABLE GUDANG CASCADE CONSTRAINT;
DROP TABLE RAK CASCADE CONSTRAINT;
DROP TABLE DETAIL_KELUAR CASCADE CONSTRAINT;
DROP TABLE TRANS_KELUAR CASCADE CONSTRAINT;
DROP TABLE RAK_BARANG CASCADE CONSTRAINT;
DROP TABLE STOK_OPNAME CASCADE CONSTRAINT;


 CREATE TABLE GUDANG
(
 KDGUDANG VARCHAR2(8) CONSTRAINT PK_GUDANG PRIMARY KEY,
 NMGUDANG VARCHAR2(15),
 ALAMAT VARCHAR2(100),
 KOTA VARCHAR2(20),
 TELP VARCHAR2(12),
 PIC VARCHAR2(20)
);
 
 CREATE TABLE TIPE
(
 KDTYPE VARCHAR2(8) CONSTRAINT PK_TYPE PRIMARY KEY,
 NMTYPE VARCHAR2(20)
 );
 
 CREATE TABLE RAK
(
 KDRAK VARCHAR2(8) CONSTRAINT PK_RAK PRIMARY KEY,
 KDTYPE VARCHAR2(15),
 constraint FK0_RAK foreign key(KDTYPE) 
    references TIPE(KDTYPE)
);

CREATE TABLE BRAND
(
 KDBRAND VARCHAR2(8) CONSTRAINT PK_BRAND PRIMARY KEY,
 NMBRAND VARCHAR2(20)
 );

 CREATE TABLE BARANG
(
 KDBARANG VARCHAR2(8) CONSTRAINT PK_BARANG PRIMARY KEY,
 NMBARANG VARCHAR2(30),
 SPESIFIKASI VARCHAR2(100),
 KDTYPE VARCHAR2(8),
 KDBRAND VARCHAR2(8),
 STOK NUMBER(5),
 constraint FK0_BARANG foreign key(KDTYPE) 
    references TIPE(KDTYPE),
 constraint FK1_BARANG foreign key(KDBRAND) 
    references BRAND(KDBRAND)	
);

DROP TABLE STOK_OPNAME CASCADE CONSTRAINT;
CREATE TABLE STOK_OPNAME
(
 KDBARANG VARCHAR2(8),
 TGL_STOK DATE,
 ACTUAL NUMBER(5),
 SELISIH NUMBER(5),
 STATUS VARCHAR2(30),
 constraint PK_STOK_OPNAME primary key(KDBARANG,TGL_STOK),
 constraint FK_STOK_OPNAME foreign key(KDBARANG) 
    references BARANG(KDBARANG) deferrable initially deferred 	
);
 
 CREATE TABLE TRANS_MASUK
(
 KDTRANSMASUK VARCHAR2(8) CONSTRAINT PK_TRANS_MASUK PRIMARY KEY,
 KDGUDANG VARCHAR2(8),
 KDRAK VARCHAR2(8),
 TGL_MASUK DATE,
 constraint FK0_TRANS_MASUK foreign key(KDGUDANG) 
   references GUDANG(KDGUDANG),	
  constraint FK1_TRANS_MASUK foreign key(KDRAK) 
    references RAK(KDRAK)
);

 CREATE TABLE DETAIL_MASUK
(
 KDTRANSMASUK VARCHAR2(8),
 KDBARANG VARCHAR2(8),
 KONDISI VARCHAR2(10),
 JUMLAH NUMBER(5),
 SATUAN VARCHAR2(8),
 constraint pk_DETAIL_MASUK primary key(KDTRANSMASUK,KDBARANG),
 constraint FK0_DETAIL_MASUK foreign key(KDBARANG) 
    references BARANG(KDBARANG),
constraint FK1_DETAIL_MASUK foreign key(KDTRANSMASUK) 
    references TRANS_MASUK(KDTRANSMASUK) deferrable initially deferred 	
);

CREATE TABLE TRANS_KELUAR
(
 KDTRANSKELUAR VARCHAR2(8),
 KDGUDANG VARCHAR2(8),
 KDRAK VARCHAR2(8),
 TGL_KELUAR DATE,
 constraint pk_trans_keluar primary key(KDTRANSKELUAR),
  constraint FK0_TRANS_KELUAR foreign key(KDGUDANG) 
    references GUDANG(KDGUDANG),	
 constraint FK1_TRANS_KELUAR foreign key(KDRAK) 
    references RAK(KDRAK)
);


 CREATE TABLE DETAIL_KELUAR
(
 KDTRANSKELUAR VARCHAR2(8),
 KDBARANG VARCHAR2(8),
 JUMLAH NUMBER(5),
 KONDISI VARCHAR2(20),
 constraint PK_DETAIL_KELUAR primary key(KDTRANSKELUAR, kdbarang),
 constraint FK0_DETAIL_KELUAR foreign key(KDBARANG) 
    references BARANG(KDBARANG),
 constraint FK1_DETAIL_KELUAR foreign key(KDTRANSKELUAR) 
    references TRANS_KELUAR(KDTRANSKELUAR) deferrable initially deferred 	
);

 CREATE TABLE RAK_BARANG
(
 KDRAKBARANG VARCHAR2(8) CONSTRAINT PK_RAKBARANG PRIMARY KEY,
 KDBARANG VARCHAR2(8),
 KDRAK VARCHAR2(8),
 LABEL_BARANG VARCHAR2(13),
 constraint FK0_RAKBARANG foreign key(KDBARANG) 
    references BARANG(KDBARANG),
 constraint FK1_RAKBARANG foreign key(KDRAK) 
    references RAK(KDRAK)	
);
 
INSERT INTO GUDANG VALUES ('GD0001','GUDANG SURABAYA','JL. LEBAK JAYA 3/26','SURABAYA',085733692929,'FRANSISCA');
INSERT INTO GUDANG VALUES ('GD0002','GUDANG SIDOARJO','JL. DELTA 2/21','SIDOARJO',0313890555,'JIMMY');
INSERT INTO TIPE VALUES ('TP0001','LEMARI ES');
INSERT INTO TIPE VALUES ('TP0002','AIR CONDITIONER');

INSERT INTO RAK VALUES ('RAK001','TP0001');
INSERT INTO RAK VALUES ('RAK002','TP0002');

INSERT INTO BRAND VALUES ('BD0001','SHARP');
INSERT INTO BRAND VALUES ('BD0002','POLYTRON');

