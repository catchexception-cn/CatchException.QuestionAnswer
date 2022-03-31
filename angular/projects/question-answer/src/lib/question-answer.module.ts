import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { QuestionAnswerComponent } from './components/question-answer.component';
import { QuestionAnswerRoutingModule } from './question-answer-routing.module';

@NgModule({
  declarations: [QuestionAnswerComponent],
  imports: [CoreModule, ThemeSharedModule, QuestionAnswerRoutingModule],
  exports: [QuestionAnswerComponent],
})
export class QuestionAnswerModule {
  static forChild(): ModuleWithProviders<QuestionAnswerModule> {
    return {
      ngModule: QuestionAnswerModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<QuestionAnswerModule> {
    return new LazyModuleFactory(QuestionAnswerModule.forChild());
  }
}
