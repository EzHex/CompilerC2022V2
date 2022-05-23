grammar c2022v2;

program: funMain* EOF;

funMain:
    'main:' line* 'endMain' ';'
|   funcDeclaration
;

line:
    statement
|   funCall
|   ifBlock 
|   forBlock 
|   whileBlock
;

funcDeclaration:
   'fun' IDENTIFIER '(' (IDENTIFIER (',' IDENTIFIER)* )? ')' line* 'endFun' ';'
;

statement: (mathAssignment|assignment|arrayAssignment|funCall|printCall|bindCall|unaryOperation) ';';

mathAssignment: IDENTIFIER (numericAss) expression;

assignment: TYPE? IDENTIFIER '=' expression;

arrayAssignment: (TYPE IDENTIFIER '[' expression ']') | (IDENTIFIER '[' (expression) ']' '=' expression);

unaryOperation : IDENTIFIER unaryOp;

funCall: IDENTIFIER '(' (IDENTIFIER (',' IDENTIFIER )*)? ')';
bindCall : BIND '(' IDENTIFIER (',' IDENTIFIER )+ ')';
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
|   IDENTIFIER '[' (expression) ']'         #arrayExp
|   funCall                                 #functionCallExpression
|   '(' expression ')'                      #parenthesesExpression
|   '!' expression                          #booleanUnaryExpression
|   expression booleanBinaryOp expression   #booleanBinaryOpExpression
|   expression numericMultiOp expression    #numericMultiOpExpression
|   expression numericAddOp expression      #numericAddOpExpression
|   expression comp expression              #booleanCompareExpression
;

numericAss : '*=' | '/=' | '%='| '+=' | '-=';
numericMultiOp : '*' | '/' | '%' ;
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