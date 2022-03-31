import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'QuestionAnswer',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44323',
    redirectUri: baseUrl,
    clientId: 'QuestionAnswer_App',
    responseType: 'code',
    scope: 'offline_access QuestionAnswer role email openid profile',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44323',
      rootNamespace: 'CatchException.QuestionAnswer',
    },
    QuestionAnswer: {
      url: 'https://localhost:44387',
      rootNamespace: 'CatchException.QuestionAnswer',
    },
  },
} as Environment;
