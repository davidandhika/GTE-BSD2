create or replace function generate
return varchar2
is
	tempkode varchar2(8);
	counter number(8);
begin
	select count(*) into counter from GUDANG;
	tempkode :=  'GD' || lpad(counter+1,4,'0');
	return tempkode;
end;
/
show err;

create or replace function generateBarang
return varchar2
is
	tempkode varchar2(8);
	counter number(8);
begin
	select count(*) into counter from BARANG;
	tempkode :=  'BR' || lpad(counter+1,4,'0');
	return tempkode;
end;
/
show err;

create or replace function generateBrand
return varchar2
is
	tempkode varchar2(8);
	counter number(8);
begin
	select count(*) into counter from BRAND;
	tempkode :=  'BR' || lpad(counter+1,4,'0');
	return tempkode;
end;
/
show err;

create or replace function generateRak
return varchar2
is
	tempkode varchar2(8);
	counter number(8);
begin
	select count(*) into counter from RAK;
	tempkode :=  'RAK' || lpad(counter+1,3,'0');
	return tempkode;
end;
/
show err;

create or replace function generateType
return varchar2
is
	tempkode varchar2(8);
	counter number(8);
begin
	select count(*) into counter from TIPE;
	tempkode :=  'TP' || lpad(counter+1,4,'0');
	return tempkode;
end;
/
show err;

create or replace function generateRakBarang
return varchar2
is
	tempkode varchar2(8);
	counter number(8);
begin
	select count(*) into counter from RAK_BARANG;
	tempkode :=  'RB' || lpad(counter+1,6,'0');
	return tempkode;
end;
/
show err;

'---------- TRIGGER UPDATE STOK --------'

CREATE OR REPLACE TRIGGER TG_STOKUPDATE_KELUAR
BEFORE INSERT OR UPDATE OF JUMLAH ON DETAIL_KELUAR
FOR EACH ROW
BEGIN
 UPDATE BARANG SET STOK = STOK - :NEW.JUMLAH
 WHERE KDBARANG = :NEW.KDBARANG;
END;
/
show err;

CREATE OR REPLACE TRIGGER TG_STOKUPDATE_MASUK
BEFORE INSERT OR UPDATE OF JUMLAH ON DETAIL_MASUK
FOR EACH ROW
BEGIN
 UPDATE BARANG SET STOK = STOK + :NEW.JUMLAH
 WHERE KDBARANG = :NEW.KDBARANG;
END;
/
show err;