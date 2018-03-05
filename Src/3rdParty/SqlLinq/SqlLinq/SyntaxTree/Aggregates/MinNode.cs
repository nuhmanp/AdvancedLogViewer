﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlLinq.SyntaxTree.Aggregates
{
    [SyntaxNode(RuleConstants.RULE_AGGREGATE_MIN_LPARAN_RPARAN)]
    public class MinNode : AggregateNode
    {
        public MinNode()
        {
            Name = "Min";
        }
    }
}
