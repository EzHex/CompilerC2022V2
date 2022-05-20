grammar c2022v2;

program: line* EOF;

line: statement | ifBlock | forBlock | whileBlock;

statement: (assignment|funCall) ';';

assignment: IDENTIFIER '=' expression;

funCall: IDENTIFIER '(' (expression (',' expression )*)? ')';

ifBlock: 'if' '(' expression ')' block 'ifend' ';' ;

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
;

mul: '*';
div: '/' | '%';
add: '+';
sub: '-';
comp: '==' | '!=' | '>' | '<' | '<=' | '>=';

constant: INTEGER | DOUBLE | CHAR | BOOL | NULL;

INTEGER: [0-9]+;
DOUBLE: [0-9]+ '.' [0-9]+;
CHAR: [a-zA-Z];
BOOL: 'true' | 'false';
NULL: 'null';

IDENTIFIER: [a-zA-Z_]([a-zA-Z0-9])*;
WS: [\t\r\n]+ -> skip;