import { TestBed, async, inject } from '@angular/core/testing';

import { NavigationStateGuard } from './navigation-state.guard';

describe('NavigationStateGuard', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NavigationStateGuard]
    });
  });

  it('should ...', inject([NavigationStateGuard], (guard: NavigationStateGuard) => {
    expect(guard).toBeTruthy();
  }));
});
