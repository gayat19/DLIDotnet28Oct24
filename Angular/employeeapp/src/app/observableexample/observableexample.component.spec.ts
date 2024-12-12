import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObservableexampleComponent } from './observableexample.component';

describe('ObservableexampleComponent', () => {
  let component: ObservableexampleComponent;
  let fixture: ComponentFixture<ObservableexampleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ObservableexampleComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ObservableexampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
