﻿ALTER TABLE Contract
DROP CONSTRAINT DF__Contract__Status__282DF8C2;

ALTER TABLE Contract
DROP COLUMN Status
     
ALTER TABLE Contract
ADD Status INT 
