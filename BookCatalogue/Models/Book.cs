using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogue.Models
{
    public class Book
    {
        /// <summary>
        /// Номер книги
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название книги
        /// </summary>
        [Required(ErrorMessage = "Введите название")]
        public string Title { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        [Required(ErrorMessage = "Введите жанр")]
        public Genres Genre { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        [Required(ErrorMessage = "Введите цену")]
        public int Price { get; set; }
        /// <summary>
        /// Количество страниц книги
        /// </summary>
        [Required(ErrorMessage = "Введите количество страниц")]
        public int PageCount { get; set; }
    }

    public enum Genres
    {
        Detective,
        Fantasy,
        Fiction,
        Adventures,
        Horror,
        RomanceNovel,
        Tale,
        Comics,
        Biography
    }
}
