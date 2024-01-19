import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReklamaComponent } from './reklama.component';

describe('ReklamaComponent', () => {
  let component: ReklamaComponent;
  let fixture: ComponentFixture<ReklamaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReklamaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ReklamaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
