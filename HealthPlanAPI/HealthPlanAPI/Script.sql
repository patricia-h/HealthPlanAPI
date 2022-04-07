INSERT INTO `db_healthplan`.`planoperator`
VALUES(1, 24740061000153, 'North Europa SA', 'North Europa', 'Avenida Paulista 1000', 0);

INSERT INTO `db_healthplan`.`planoperator`
VALUES(2, 36780173000117, 'Pampulha Intermédica SA', 'Pampulha Intermedica', 'Avenida Paulista 2000', 1);

INSERT INTO `db_healthplan`.`planoperator`
VALUES(3, 78311853000131, 'Dental Sorriso SA', 'Dental Sorriso', 'Avenida Paulista 3000', 2);

INSERT INTO `db_healthplan`.`planoperator`
VALUES(4, 78430125000149, 'Mental Health SA', 'Mente Sã, Corpo São', 'Avenida Paulista 4000', 3);

INSERT INTO `db_healthplan`.`plan`
VALUES (1, 'Plano de saúde North Europa', 0, 500, 1);

INSERT INTO `db_healthplan`.`plan`
VALUES (2, 'Plano de saúde Pampulha Intermédica', 0, 600, 2);

INSERT INTO `db_healthplan`.`plan`
VALUES (3, 'Plano odontológico Dental Sorriso', 0, 250, 3);

INSERT INTO `db_healthplan`.`plan`
VALUES (4, 'Plano de saúde mental Mente Sã, Corpo São', 0, 250, 4);

insert into `db_healthplan`.`beneficiary`
values(1, '93228118037', 'Patricia', now(), 'patricia@gmail.com', 'Avenida Principal', 60, 1.60, 0, 1);