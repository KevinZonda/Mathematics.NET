﻿using static Kevin.Pseudocode.Basic;
using static Kevin.Pseudocode.IO;
using static Kevin.Pseudocode.Env;
using static Kevin.Pseudocode.Array;

var j = 0;
FOR_LOOP_IN_RANGE(1, 10, (i) =>
{
    IF(i % 2 == 0,
        () => PRINTLINE("HELLO!"),
        () => PRINTLINE("WORLD!", "HI"));
});
PRINT(j);

int i = 10;
WHILE(() => i > 100, () =>
{
    i = i * 2;
    PRINTLN(i);
    PRINTLN(i< 100);
});

WHILE(i > 100, () =>
{
    i = i * 2;
    PRINTLN(i);
    PRINTLN(i< 100);
});
