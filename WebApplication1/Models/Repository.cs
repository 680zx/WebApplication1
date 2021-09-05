﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class Repository
    {
        private static List<UserAnswer> _userAnswers = new List<UserAnswer>();

        public static IEnumerable<UserAnswer> UserAnswers
        {
            get => _userAnswers;
        }

        public static void AddUserAnswer(UserAnswer userAnswer)
        {
            _userAnswers.Add(userAnswer);
        }
    }
}
