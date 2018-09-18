import { TestBed } from '@angular/core/testing';

import { SchoolUserHttpService } from './school-user-http.service';

describe('SchoolUserHttpService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SchoolUserHttpService = TestBed.get(SchoolUserHttpService);
    expect(service).toBeTruthy();
  });
});
