import { ModuleWithProviders, NgModule } from '@angular/core';
import { QUESTION_ANSWER_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class QuestionAnswerConfigModule {
  static forRoot(): ModuleWithProviders<QuestionAnswerConfigModule> {
    return {
      ngModule: QuestionAnswerConfigModule,
      providers: [QUESTION_ANSWER_ROUTE_PROVIDERS],
    };
  }
}
