grammar c2022v2;

program: line* EOF;

line: 
    statement
|   ifBlock 
|   forBlock 
|   whileBlock
;

statement: (mathAssignment|assignment|arrayAssignment|funCall|printCall|bindCall) ';';

mathAssignment: IDENTIFIER (numericMultiAss|numericAddAss) expression;
assignment: TYPE? IDENTIFIER '=' expression;
arrayAssignment: (TYPE IDENTIFIER '[' INTEGER ']') | (IDENTIFIER '[' INTEGER ']' '=' expression);
unaryOperation : IDENTIFIER unaryOp;

funCall: TYPE IDENTIFIER '(' (expression (',' expression )*)? ')';
bindCall : BIND '(' (expression (',' expression )*)? ')';
printCall: PRINT '(' expression ')';

ifBlock: 'if' '(' expression ')' block elseifBlock* elseBlock? 'ifend' ';' ;
elseifBlock: 'elseif' '(' expression ')' block;
elseBlock: 'else' block;

forBlock: 'for' '(' assignment ';' expression ';' expression ')' block 'forend' ';';

whileBlock: 'while' expression block 'whileend' ';';

block: line+ ;

expression:
    constant                                #constantExpression
|   IDENTIFIER                              #identifierExpression
|   IDENTIFIER unaryOp                      #unaryOpExpression
|   funCall                                 #functionCallExpression
|   '(' expression ')'                      #parenthesesExpression
|   '!' expression                          #booleanUnaryExpression
|   expression booleanBinaryOp expression   #booleanBinaryOpExpression
|   expression numericMultiOp expression    #numericMultiOpExpression
|   expression numericAddOp expression      #numericAddOpExpression
|   expression comp expression              #booleanCompareExpression
;

numericMultiAss : '*=' | '/=' | '%=';
numericMultiOp : '*' | '/' | '%' ;
numericAddAss : '+=' | '-=';
numericAddOp : '+' | '-' ;
unaryOp: '++' | '--';
booleanBinaryOp : '||' | '&&' ;
comp: '==' | '!=' | '>' | '<' | '<=' | '>=';

constant: INTEGER | DOUBLE | CHAR | BOOL | NULL;


PRINT: 'print';
BIND : 'bind' | 'unbind';
TYPE: 'int' | 'double' | 'char' | 'bool' | 'void';

INTEGER: [0-9]+;
DOUBLE: [0-9]+ '.' [0-9]+;
CHAR: '\''[a-zA-Z]'\'';
BOOL: 'true' | 'false';
NULL: 'null';

IDENTIFIER:
    [a-zA-Z_][a-zA-Z_0-9]*
;
COMMENT : ( '//' ~[\r\n]* | '/*' .*? '*/' ) -> skip ;
WS: [ \t\r\n]+ -> skip;