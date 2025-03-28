## File SQL for Application

create table PROBLEME (
codeProbleme char(4),
libelleProbleme varchar(40),
constraint PK_codePB primary key nonclustered (codeProbleme)
)engine=innodb;

create table CONTAINER (
numContainer int(6) AUTO_INCREMENT,
dateAchat date,
typeContainer varchar(40),
dateDerniereInsp date,
constraint PK_numCont primary key nonclustered (numContainer)
)engine=innodb;

create table DECLARATION (
codeDeclaration int (6) AUTO_INCREMENT,
commentaireDeclaration varchar (100),
dateDeclaration date not null,
urgence bool DEFAULT FALSE,
traité bool DEFAULT FALSE,
numContainer int (6),
constraint PK_codeDecla primary key nonclustered (codeDeclaration),
constraint FK_numCont foreign key (numContainer) references CONTAINER (numContainer)
)engine=innodb;

create table TRAVAUX (
codeTravaux char(6),
libelleTravaux varchar (30),
duree_Immobilisation int(3),
constraint PK_codeTravaux primary key nonclustered (codeTravaux)
)engine=innodb;

create table INSPECTION (
numInspection int(3),
numContainer int(6),
libelleMotif ENUM('Visite annuelle','Problème','Recyclage','Autre'),
libelleEtat ENUM('Prévue','En cours','Finie'),
constraint PK_numInspec primary key nonclustered (numInspection, numContainer),
constraint FK_numContainer foreign key (numContainer) references CONTAINER (numContainer)
)engine=innodb;

create table DECISION (
codeTravaux char(6),
numInspection int (3),
dateEnvoi date,
dateRetour date,
commentaireDecision varchar(100),
constraint PK_codeTravaux primary key nonclustered (codeTravaux, numInspection),
constraint FK_numInspection foreign key (numInspection) references INSPECTION (numInspection),
constraint FK_codeTrav foreign key (codeTravaux) references TRAVAUX (codeTravaux)
)engine=innodb
