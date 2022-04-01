import { Component, OnInit } from '@angular/core';
import { QuestionAnswerService } from '../services/question-answer.service';

@Component({
  selector: 'lib-question-answer',
  template: ` <p>question-answer works!</p> `,
  styles: [],
})
export class QuestionAnswerComponent implements OnInit {
  constructor(private service: QuestionAnswerService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
