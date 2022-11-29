grammar recipebook;

recipebook: book EOF;

book: entry+;

entry:
	recipe_tag portions_tag prep_time_tag? cooking_time_tag? calories_tag ingredients_tag
		elaboration_tag;

// recipe
recipe_tag: LINE_START REC_LBL SEP WS recipe_name NL;
recipe_name: text;

// portion
portions_tag:
	LINE_START POR_LBL SEP WS amount WS portion_unit NL;
portion_unit: text;

// prep time
prep_time_tag: LINE_START TMP_LBL SEP WS time NL;

// cooking time
cooking_time_tag: LINE_START TMC_LBL SEP WS time NL;

// calories
calories_tag: LINE_START CAL_LBL SEP WS calories_content NL;
calories_content: amount WS calorie_unit;
calorie_unit: text;

// ingredients
ingredients_tag: LINE_START ING_LBL SEP NL ingredient_list NL;
ingredient_list:
	ingredient_list_item (COM NL ingredient_list_item)*;
ingredient_list_item: TAB amount WS ingredient;
ingredient: (measure WS)? ingredient_name;
measure: MEASURE_UNIT;
ingredient_name: text;

// elaboration
elaboration_tag: LINE_START ELA_LBL SEP NL elaboration_list NL?;
elaboration_list:
	elaboration_list_item (NL elaboration_list_item)*;
elaboration_list_item: TAB list_order WS instruction;
list_order: order LIST_ORDER_SEP;
order: NUMBER;
instruction: text;

// General units
time: amount WS time_unit;
time_unit: TIME_UNIT;
amount: NUMBER;

text: WORD | WORD (WS WORD)*;

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

TIME_UNIT: (
		'min'
		| 'minute'
		| 'sec'
		| 'second'
		| 'hr'
		| 'hour'
		| 'day'
	) 's'?;

MEASURE_UNIT: (
		'taza'
		| 'cucharadita'
		| 'cup'
		| 'guieno'
		| 'batata'
		| 'cucharada'
	) 's'?;

WORD: [A-Za-z_]+;

LIST_ORDER_SEP: ')';
COM: ',';
SEP: ':';
TAB: '\t';
WS: ' '+;
NL: '\n';

NUMBER: INTEGER | FLOAT;
FLOAT: [0-9]+ '.' [0-9]+;
INTEGER: [0-9]+;

CARRRET: '\r' -> skip;
