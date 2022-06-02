grammar Testlang;
/*
 * Parser Rules
 */
program_title		: TRADENAME PROGRAM NAME eol*;
eol					: EOL+;

/*
 * Lexer Rules
 */
TRADENAME			: 'TRADENAME';
PROGRAM				: 'PROGRAM';
NAME				: [a-zA-Z0-9_.]* ;
EOL					: ('\n' | '\r\n' | ';') ;
WHITESPACE          : (' '|'\t')+ -> skip ;