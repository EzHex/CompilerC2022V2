grammar Simple;

program: line* EOF;

line: statement | ifBlock | forBlock | whileBlock;

statement: (assignment|funCall) ';';

ifBlock: 'if' '(' expression block ')' ('else' elseIfBlock)?; 
elseIfBlock: block | ifBlock;

forBlock: 'for' '(' assignment ';' expression ';' expression ')' block;

whileBlock: 'while' expression block;

assignment: IDENTIFIER '=' expression;

funCall: IDENTIFIER '(' (expression (',' expression )*)? ')';

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

block: '{' line+ '}';

IDENTIFIER: [a-zA-Z_][a-zA-Z0-9]*;
WS: [\t\r\n]+ -> skip;