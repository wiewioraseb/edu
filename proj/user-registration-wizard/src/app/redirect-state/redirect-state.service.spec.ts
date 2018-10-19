import { TestBed } from '@angular/core/testing';

import { RedirectStateService } from './redirect-state.service';

describe('RedirectStateService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RedirectStateService = TestBed.get(RedirectStateService);
    expect(service).toBeTruthy();
  });
});
