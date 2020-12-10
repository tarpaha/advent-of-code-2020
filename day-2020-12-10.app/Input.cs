﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_10.app
{
    public static class Input
    {
        public static IEnumerable<int> GetData()
        {
            return GetDataText()
                .Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

        private static string GetDataText()
        {
            return @"
18
47
144
147
124
45
81
56
16
59
97
83
75
150
33
165
30
159
84
141
104
25
164
90
92
88
2
8
51
24
153
63
27
123
127
58
108
52
38
15
149
66
72
21
46
89
135
55
34
37
78
65
134
148
76
138
103
162
114
109
42
77
102
163
7
105
69
39
91
111
131
130
6
137
96
82
64
3
95
136
85
9
116
17
99
12
117
62
50
110
26
115
71
57
156
120
98
1
70";
        }
    }
}