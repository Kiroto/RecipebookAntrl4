grammar recipebook;

recipebook: book EOF;

book: entry+;

entry:
	recipe_tag portions_tag prep_time_tag? cooking_time_tag? calories_tag ingredients_tag
		elaboration_tag;

// recipe
recipe_tag: LINE_START REC_LBL SEP recipe_name NL;
recipe_name: TEXT;

// portion
portions_tag: LINE_START POR_LBL SEP amount WS portion_unit NL;
portion_unit: TEXT;

// prep time
prep_time_tag: LINE_START TMP_LBL SEP time NL;

// cooking time
cooking_time_tag: LINE_START TMC_LBL SEP time NL;

// calories
calories_tag: LINE_START CAL_LBL SEP calories_content NL;
calories_content: amount WS calorie_unit;
calorie_unit: TEXT;

// ingredients
ingredients_tag: LINE_START ING_LBL SEP NL ingredient_list NL;
ingredient_list:
	ingredient_list_item (COM NL ingredient_list_item)*;
ingredient_list_item: TAB amount WS ingredient_name;
ingredient_name: TEXT;

// elaboration
elaboration_tag:
	LINE_START ELA_LBL SEP NL elaboration_list NL?;
elaboration_list:
	elaboration_list_item (NL elaboration_list_item)*;
elaboration_list_item: order LIST_ORDER_SEP WS instruction;
order: INT;
instruction: TEXT;

// General units
time: amount WS time_unit;
time_unit: (
		'min'
		| 'minute'
		| 'sec'
		| 'second'
		| 'hr'
		| 'hour'
		| 'day'
	) 's'?;

amount: NUMBER;

// Terminals
LINE_START: GUION WS;

GUION: '-';
REC_LBL: 'RECETA';
POR_LBL: 'PORCIONES';
TMP_LBL: 'TIEMPO PREPARACION';
TMC_LBL: 'TIEMPO COCCION';
CAL_LBL: 'CALORIAS';
ING_LBL: 'INGREDIENTES';
ELA_LBL: 'ELABORACION';

LIST_ORDER_SEP: ')';
COM: ',';
SEP: ':';
TAB: '\t';
WS: ' '+;
NL: '\n';

NUMBER: INT | FLOAT;
FLOAT: [0-9]+ '.' [0-9]+;

INT: [0-9]+;

TEXT: WORD (WS WORD)*;
WORD: [A-Za-z_]+;
CARRRET: '\r' -> skip;
