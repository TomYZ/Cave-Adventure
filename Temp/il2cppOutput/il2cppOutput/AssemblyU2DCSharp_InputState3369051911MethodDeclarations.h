#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// InputState
struct InputState_t3369051911;

#include "codegen/il2cpp-codegen.h"
#include "AssemblyU2DCSharp_Buttons1906005857.h"

// System.Void InputState::.ctor()
extern "C"  void InputState__ctor_m3802786164 (InputState_t3369051911 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void InputState::Awake()
extern "C"  void InputState_Awake_m4040391383 (InputState_t3369051911 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void InputState::FixedUpdate()
extern "C"  void InputState_FixedUpdate_m3660832751 (InputState_t3369051911 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void InputState::SetButtonValue(Buttons,System.Boolean)
extern "C"  void InputState_SetButtonValue_m552568153 (InputState_t3369051911 * __this, int32_t ___key0, bool ___value1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean InputState::GetButtonValue(Buttons)
extern "C"  bool InputState_GetButtonValue_m3898513252 (InputState_t3369051911 * __this, int32_t ___key0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Single InputState::GetButtonHoldTime(Buttons)
extern "C"  float InputState_GetButtonHoldTime_m3981691831 (InputState_t3369051911 * __this, int32_t ___key0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
