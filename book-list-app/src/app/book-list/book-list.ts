import { Component } from '@angular/core';
import { Book } from '../book'; 
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-book-list',
  imports: [CommonModule],
  templateUrl: './book-list.html',
  styleUrl: './book-list.css',
})
export class BookList {
  books: Book[] = [
    { id: 1, title: 'The Great Gatsby', author: 'F. Scott Fitzgerald' },
    { id: 2, title: 'To Kill a Mockingbird', author: 'Harper Lee'},
    { id: 3, title: '1984', author: 'George Orwell' },
  ];
}
