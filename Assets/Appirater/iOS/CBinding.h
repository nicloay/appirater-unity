//
//  CBinding.h
//  rateus test
//
//  Created by nicloay on 29/11/2017.
//  Copyright © 2017 nicloay.com. All rights reserved.
//

#ifndef CBinding_h
#define CBinding_h


#ifdef __cplusplus
extern "C" {
#endif
    
    void _Init(const char* appId,
               const int daysUntilPrompt,
               const int usesUntilPrompt,
               const int significantEventsUntilPrompt,
               const int timeBeforeReminding,
               const bool debug);
    
    void _DidSignificantEvent();
    
    void _AppGoesToBackground(const bool bg);

    
#ifdef __cplusplus
}
#endif


#endif /* CBinding_h */