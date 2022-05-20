grammar c2022v2;

program: line* EOF;

line: statement 
    | ifBlock 
    | forBlock 
    | whileBlock
    ;

statement: (assignment|funCall|printCall) ';';

assignment: IDENTIFIER '=' expression;

funCall: IDENTIFIER '(' (expression (',' expression )*)? ')';

printCall: PRINT '(' expression ')';

ifBlock: 'if' '(' expression ')' block elseifBlock* elseBlock? 'ifend' ';' ;
elseifBlock: 'elseif' '(' expression ')' block;
elseBlock: 'else' block;

forBlock: 'for' '(' assignment ';' expression ';' expression ')' block 'forend' ';';

whileBlock: 'while' expression block 'whileend' ';';

block: line+ ;

expression:
    constant
|   IDENTIFIER
|   funCall
|   '(' expression ')'
|   '!' expression
|   expression comp expression
|   expression mul expression
|   expression div expression
|   expression add expression
|   expression sub expression 
|   expression unaryadd //TODO FIX CAUSE IT CAN TAKE FUNCCALL++
|   expression unarysub //SAME
//TODO FIX += -= *= /=
;

mul: '*';
div: '/' | '%';
add: '+';
unaryadd: '++';
unarysub: '--';
sub: '-';
comp: '==' | '!=' | '>' | '<' | '<=' | '>=';

constant: INTEGER | DOUBLE | CHAR | BOOL | NULL;

PRINT: 'print';

INTEGER: [0-9]+;
DOUBLE: [0-9]+ '.' [0-9]+;
CHAR: '\''[a-zA-Z]'\'';
BOOL: 'true' | 'false';
NULL: 'null';

IDENTIFIER
    : [a-zA-Z_][a-zA-Z_0-9]*
    ;
COMMENT : ( '//' ~[\r\n]* | '/*' .*? '*/' ) -> skip ;
WS: [ \t\r\n]+ -> skip;