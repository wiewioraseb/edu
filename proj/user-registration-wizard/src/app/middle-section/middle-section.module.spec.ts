import { MiddleSectionModule } from './middle-section.module';

describe('MiddleSectionModule', () => {
  let middleSectionModule: MiddleSectionModule;

  beforeEach(() => {
    middleSectionModule = new MiddleSectionModule();
  });

  it('should create an instance', () => {
    expect(middleSectionModule).toBeTruthy();
  });
});
