﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TesteEmpresa
{
    public static class descerializar
    {


        public static Alunos[]? executar()
        {
            var json = @"[
  {
    ""nome"": ""aluno6"",
    ""notas"": [ 10, 9, 10 ]
  },
  {
    ""nome"": ""aluno7"",
    ""notas"": [ 5, 6, 5 ]
  },
  {
    ""nome"": ""aluno1"",
    ""notas"": [ 3, 4, 10, 4, 10, 10, 10, 1 ]
  },
  {
    ""nome"": ""aluno3"",
    ""notas"": [ 4, 3, 3 ]
  },
  {
    ""nome"": ""aluno5"",
    ""notas"": [ 3, 4, 10 ]
  },
  {
    ""nome"": ""aluno4"",
    ""notas"": [ 3, 4, 10 ]
  },
  {
    ""nome"": ""aluno2"",
    ""notas"": [ 3, 4, 10 ]
  }
]

 ";

           return JsonSerializer.Deserialize<Alunos[]>(json);
        }
    }

}






