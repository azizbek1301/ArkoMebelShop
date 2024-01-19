import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KuhnniComponent } from './kuhnni.component';

describe('KuhnniComponent', () => {
  let component: KuhnniComponent;
  let fixture: ComponentFixture<KuhnniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [KuhnniComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(KuhnniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
